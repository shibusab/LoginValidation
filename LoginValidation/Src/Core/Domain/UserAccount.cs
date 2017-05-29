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

namespace LoginValidation.Core.Domain
{
	/// <summary>
	/// Description of UserAccount.
	/// </summary>
	public class UserAccount
	{
		private string email = string.Empty;
        public double UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double CompanyID { get; set; }
        public string CompanyName{ get; set; }
        public string Email { get { return email; } set { email = value; } }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }
        public bool ChangePasswordAtLogin { get; set; }
        public string PassKey {get;set;}
        public bool IsAuthenticated { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Role { get; set; }
        public double LoginAttempts { get; set; }
        public DateTime LastPasswordChanged {get;set;}

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string CreatedDateAsString { get { return (CreatedDate.Equals(DateTime.MinValue) ? string.Empty : CreatedDate.ToString("MM/dd/yyyy")); } }
        public string LastUpdatedDateAsString { get { return (LastUpdatedDate.Equals(DateTime.MinValue) ? string.Empty : LastUpdatedDate.ToString("MM/dd/yyyy")); } }
         
        public bool IsNotActive { get { return !IsActive; } }
        public bool IsNotAuthenticated { get { return !IsAuthenticated; } }
        public bool HasEmailAccount { get { return email.Length > 0; } }

        public bool IsValid()
        {
            bool retVal = false;
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
            { retVal = true; }

            return retVal;
        }
		
	}
}
