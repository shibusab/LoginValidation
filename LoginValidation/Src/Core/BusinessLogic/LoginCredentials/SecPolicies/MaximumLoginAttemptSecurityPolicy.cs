/*
 * Created by SharpDevelop.
 * User: shibu
 * Date: 5/28/2017
 *
 * 
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
 
using System;
using LoginValidation.Core.Domain;
using LoginValidation.Core.DataAccess;

namespace LoginValidation.Core.BusinessLogic.LoginCredentials.SecPolicies
{
	/// <summary>
	/// Description of MaximumLoginAttempt.
	/// </summary>
	public class MaximumLoginAttemptSecurityPolicy:ILoginSecurityPolicy
	{
		private readonly int accountLockoutThreshold=3;
		private readonly int lockoutDurationMinutes=10;
		private readonly IUserAccountCommandRepository commandRepository;
		public MaximumLoginAttemptSecurityPolicy(int accountLockoutThreshold, int lockoutDurationMinutes, IUserAccountCommandRepository commandRepository)
		{
			this.accountLockoutThreshold=accountLockoutThreshold;
			this.lockoutDurationMinutes=lockoutDurationMinutes;
			
			this.commandRepository=commandRepository;
		}
		
		public string Violation(UserAccount userAccount)
		{
			var retVal=string.Empty;
			
			var loginAttempts = userAccount.LoginAttempts +1;
			var lockoutDurationPassed = (userAccount.LastUpdatedDate.AddMinutes(lockoutDurationMinutes)> DateTime.Now);
			var exceededMaxLoginAttempts= (loginAttempts > accountLockoutThreshold);
			
			if(lockoutDurationPassed)
			{
				commandRepository.UnlockUser(userAccount.UserName);
				loginAttempts=1;
			}
			
			if(exceededMaxLoginAttempts)
			{
				commandRepository.LockUser(userAccount.UserName);
				retVal= "Account Locked for Too much Failed Login Attempts";
			}
			
			
			return retVal;
		}
		
	}
}
