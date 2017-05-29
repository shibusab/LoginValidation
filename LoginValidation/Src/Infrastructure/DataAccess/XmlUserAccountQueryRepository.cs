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
using LoginValidation.Core.DataAccess;
using LoginValidation.Core.Domain;
using LoginValidation.Infrastructure.Utils;
using System.Linq;

namespace LoginValidation.Infrastructure.DataAccess
{
	/// <summary>
	/// Description of XmlUserAccountQueryRepository.
	/// </summary>
	public class XmlUserAccountQueryRepository:IUserAccountQueryRepository
	{
		private readonly string xmlFileName;
		public XmlUserAccountQueryRepository(string xmlFileName)
		{
			this.xmlFileName=xmlFileName;
		}
		
		public UserAccount ValidateUser(string userName,string password)
		{
			var users= new List<UserAccount>();
			users=CustomSerializer<UserAccount>.Read(xmlFileName);
			var user= users.FirstOrDefault(p=>p.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase));
			return user;
		}
	}
}