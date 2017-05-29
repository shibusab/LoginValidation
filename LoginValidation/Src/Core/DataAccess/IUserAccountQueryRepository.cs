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

namespace LoginValidation.Core.DataAccess
{
	/// <summary>
	/// Description of IUserAccountQueryRepository.
	/// </summary>
	public interface IUserAccountQueryRepository
	{
		UserAccount ValidateUser(string userName,string password);
	}
}
