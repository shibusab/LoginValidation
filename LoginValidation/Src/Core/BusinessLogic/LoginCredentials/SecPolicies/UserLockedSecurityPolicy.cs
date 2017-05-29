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

namespace LoginValidation.Core.BusinessLogic.LoginCredentials.SecPolicies
{
	/// <summary>
	/// Description of IsUserLocked.
	/// </summary>
	public class UserLockedSecurityPolicy:ILoginSecurityPolicy
	{
		public UserLockedSecurityPolicy()
		{
		}

		public string Violation(UserAccount userAccount)
		{
			var retVal=string.Empty;
			
			if(userAccount.IsLocked)
			{
				retVal="Account is Locked";
			}
			
			return retVal;
		}
		
	}
}
