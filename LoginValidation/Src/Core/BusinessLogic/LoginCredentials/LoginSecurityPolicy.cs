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
using System.Collections.Generic;
using LoginValidation.Core.Domain;

namespace LoginValidation.Core.BusinessLogic.LoginCredentials
{
	/// <summary>
	/// Description of LoginCredentialRules.
	/// </summary>
	public class LoginSecurityPolicy
	{
		private readonly List<ILoginSecurityPolicy> loginRules ;
		
		public LoginSecurityPolicy()
		{
			loginRules = new List<ILoginSecurityPolicy>();	
		}
		
		public void AddLoginRule(ILoginSecurityPolicy loginRule)
		{
			loginRules.Add(loginRule);
		}
		
		public string ProcessRules(UserAccount userAccount)
		{
			var message=string.Empty;
			foreach( var loginRule in loginRules)
			{
				var violation=loginRule.Violation(userAccount);
				
				if( !string.IsNullOrEmpty(violation))
				{
					message += violation;
					//At first occurance of violation break skipping the rest
					break;
				}
			}
			
			return message;
		}
	}
}
