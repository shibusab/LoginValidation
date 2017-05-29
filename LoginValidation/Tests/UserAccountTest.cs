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
using LoginValidation.Core.BusinessLogic.LoginCredentials;
using LoginValidation.Infrastructure.DataAccess;
using NUnit.Framework;

namespace LoginValidation.Tests
{
	[TestFixture]
	public class UserAccountTest
	{
		[Test]
		public void UserIsAuthenticated()
		{
			const string connectionString="./users.xml";
			const int passwordExpiryDays=90;
			const int accountLockoutThreshold=9;
			const int lockoutDurationMinutes=10;
			var userCommandRepository= new XmlUserAccountCommandRepository(connectionString);
			var userQueryRepository=new XmlUserAccountQueryRepository(connectionString);
			var retVal= new LoginProcess(userCommandRepository,userQueryRepository,passwordExpiryDays,accountLockoutThreshold,lockoutDurationMinutes)
				.Login("shibu","password");
			
			Assert.IsEmpty(retVal,"User Authentication Failed");
		}
		
		/*
		[Test]
		public void CreateNewUser()
		{
			const string connectionString="./users.xml";
			var userCommandRepository= new XmlUserAccountCommandRepository(connectionString);
			new LoginProcess().AddUser();
		}
		*/
	}
}
