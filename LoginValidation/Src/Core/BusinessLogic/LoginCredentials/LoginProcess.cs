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
using LoginValidation.Core.DataAccess;
using LoginValidation.Infrastructure.DataAccess;
using LoginValidation.Core.BusinessLogic.LoginCredentials.SecPolicies;

namespace LoginValidation.Core.BusinessLogic.LoginCredentials
{
	/// <summary>
	/// Description of LoginProcess.
	/// </summary>
	public class LoginProcess
	{
		private readonly IUserAccountCommandRepository userCommandRepository=null;
		private readonly IUserAccountQueryRepository userQueryRepository=null;
		private readonly string connectionString="TEST";
		private readonly int passwordExpiryDays=90;
		private readonly int accountLockoutThreshold=9;
		private readonly int lockoutDurationMinutes=10;
		
		public LoginProcess()
		{
			userCommandRepository= new XmlUserAccountCommandRepository(connectionString);
			userQueryRepository=new XmlUserAccountQueryRepository(connectionString);
		}
		
		public LoginProcess( 
                IUserAccountCommandRepository userCommandRepository,
		        IUserAccountQueryRepository userQueryRepository,
		        int passwordExpiryDays,
		        int accountLockoutThreshold,
		        int lockoutDurationMinutes
		                   )
		{
			this.userCommandRepository= userCommandRepository;
			this.userQueryRepository=userQueryRepository;
			this.passwordExpiryDays=passwordExpiryDays;
			this.accountLockoutThreshold=accountLockoutThreshold;
			this.lockoutDurationMinutes= lockoutDurationMinutes;
			
			if(null == this.userCommandRepository)
			{
				throw new NullReferenceException();
			}
			if(null == this.userQueryRepository)
			{
				throw new NullReferenceException();
			}
		}
		
		
		public string Login(string userName,string password)
		{
			string retVal=string.Empty;
			var userAccount= userQueryRepository.ValidateUser("shibu","password");
			                                                  
			if(userAccount.IsAuthenticated)
			{
				var loginPolicies = new LoginSecurityPolicy();
				loginPolicies.AddLoginRule(new ActiveUserSecurityPolicy());
				loginPolicies.AddLoginRule(new UserLockedSecurityPolicy());
				loginPolicies.AddLoginRule(new MaximumLoginAttemptSecurityPolicy(accountLockoutThreshold,lockoutDurationMinutes,userCommandRepository));
				loginPolicies.AddLoginRule(new PasswordExpirySecurityPolicy(passwordExpiryDays));
				
				retVal= loginPolicies.ProcessRules(userAccount);
			}
			return retVal;
		}
	}
}
