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

namespace LoginValidation.Infrastructure.DataAccess
{
	/// <summary>
	/// Description of XmlUserAccountCommandRepository.
	/// </summary>
	public class XmlUserAccountCommandRepository:IUserAccountCommandRepository
	{
		private readonly string connectionString;
		public XmlUserAccountCommandRepository(string connectionString)
		{
			this.connectionString=connectionString;
		}
		
		public bool LockUser(string userName)
		{
			throw new NotImplementedException();
		}
		
		public bool UnlockUser(string userName)
		{
			throw new NotImplementedException();
		}
	}
}
