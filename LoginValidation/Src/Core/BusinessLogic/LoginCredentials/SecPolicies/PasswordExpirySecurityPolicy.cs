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
	/// Description of PasswordExpiry.
	/// </summary>
	public class PasswordExpirySecurityPolicy:ILoginSecurityPolicy
	{
		private int passwordExpiryDays=90;
		public PasswordExpirySecurityPolicy(int passwordExpiryDays)
		{
			this.passwordExpiryDays=passwordExpiryDays;
		}

		public string Violation(UserAccount userAccount)
		{
			string retVal=string.Empty;
			var actualPasswordExpiryDate=userAccount.LastPasswordChanged.AddDays(passwordExpiryDays);
			
			if (DateTime.Now < actualPasswordExpiryDate)
			{
				retVal=string.Format( "Passed {0} days, and needs to change password", passwordExpiryDays );
			}
			
			return retVal;
		}
		
	}
}
