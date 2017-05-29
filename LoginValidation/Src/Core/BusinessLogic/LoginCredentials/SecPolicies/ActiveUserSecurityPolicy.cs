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
	/// Description of IsActiveValidation.
	/// </summary>
	public class ActiveUserSecurityPolicy:ILoginSecurityPolicy
	{
		public ActiveUserSecurityPolicy()
		{
			
		}

		public string Violation(UserAccount userAccount)
		{
			string retVal=string.Empty;
			
			if(!userAccount.IsActive)
			{
				retVal="Oops. Something Went Wrong";
			}
			
			return retVal;
		}

	}
}
