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
using LoginValidation.Core.Domain;

namespace LoginValidation.Infrastructure.DataAccess
{
	/// <summary>
	/// Description of XmlUserAccountQueryRepository.
	/// </summary>
	public class XmlUserAccountQueryRepository:IUserAccountQueryRepository
	{
		private readonly string connectionString;
		public XmlUserAccountQueryRepository(string connectionString)
		{
			this.connectionString=connectionString;
		}
		
		public UserAccount ValidateUser(string userName,string password)
		{
			throw new NotImplementedException();
		}
	}
}