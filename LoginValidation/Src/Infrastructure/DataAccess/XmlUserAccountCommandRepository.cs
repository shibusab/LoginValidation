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
using System.Linq;
using LoginValidation.Core.DataAccess;
using LoginValidation.Core.Domain;
using LoginValidation.Infrastructure.Utils;
namespace LoginValidation.Infrastructure.DataAccess
{
	/// <summary>
	/// Description of XmlUserAccountCommandRepository.
	/// </summary>
	public class XmlUserAccountCommandRepository:IUserAccountCommandRepository
	{
		private readonly string xmlFileName;
		public XmlUserAccountCommandRepository(string xmlFileName)
		{
			this.xmlFileName=xmlFileName;
		}
		
		public bool LockUser(string userName)
		{
			throw new NotImplementedException();
		}
		
		public bool UnlockUser(string userName)
		{
			throw new NotImplementedException();
		}
		
		public bool SaveUser(UserAccount userAccount)
		{
			var userlist = new List<UserAccount>();
			if(System.IO.File.Exists(xmlFileName))
			{
				userlist=CustomSerializer<UserAccount>.Read(xmlFileName);
			}
			userlist.Add(userAccount);
			CustomSerializer<UserAccount>.Save(userlist,xmlFileName);
			return true;
		}
	}
}