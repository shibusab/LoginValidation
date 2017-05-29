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
	/// Description of TimeRestrictionSecurityPolicy.
	/// </summary>
	public class TimeRestrictionSecurityPolicy:ILoginSecurityPolicy
	{
		private readonly string timeRestrictions =string.Empty;
		public TimeRestrictionSecurityPolicy(string timeRestrictions)
		{
			this.timeRestrictions=timeRestrictions;
		}

		public string Violation(UserAccount userAccount)
		{
			throw new NotImplementedException();
		}

	}
}
