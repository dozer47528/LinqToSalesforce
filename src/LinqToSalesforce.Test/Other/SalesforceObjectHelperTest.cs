using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqToSalesforce.Helper;
using System.Linq;
namespace LinqToSalesforce.Test.Other
{
    [TestClass]
    public class SalesforceObjectHelperTest
    {
        [TestMethod]
        public void GetAllPropertyNamesTest()
        {
            var result = SalesforceObjectHelper.GetAllPropertyNames(typeof(SalesforceObjectHelperTestUser));
            Assert.IsTrue(result.Any());
        }
    }

    #region UserModel
    public partial class SalesforceObjectHelperTestUser
    {

        private string aboutMeField;

        private string accountIdField;

        private string aliasField;

        private string callCenterIdField;

        private string cityField;

        private string communityNicknameField;

        private string companyNameField;


        private string contactIdField;

        private string countryField;

        private User createdByField;

        private string createdByIdField;

        private System.Nullable<System.DateTime> createdDateField;

        private bool createdDateFieldSpecified;

        private string defaultGroupNotificationFrequencyField;

        private string delegatedApproverIdField;

        private string departmentField;

        private string digestFrequencyField;

        private string divisionField;

        private string emailField;

        private string emailEncodingKeyField;

        private string employeeNumberField;

        private string extensionField;

        private string faxField;

        private string federationIdentifierField;

        private string firstNameField;

        private System.Nullable<bool> forecastEnabledField;

        private bool forecastEnabledFieldSpecified;

        private string fullPhotoUrlField;

        private System.Nullable<bool> isActiveField;

        private bool isActiveFieldSpecified;

        private string languageLocaleKeyField;

        private System.Nullable<System.DateTime> lastLoginDateField;

        private bool lastLoginDateFieldSpecified;

        private User lastModifiedByField;

        private string lastModifiedByIdField;

        private System.Nullable<System.DateTime> lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string lastNameField;

        private System.Nullable<System.DateTime> lastPasswordChangeDateField;

        private bool lastPasswordChangeDateFieldSpecified;

        private string localeSidKeyField;

        private User managerField;

        private string managerIdField;

        private string mobilePhoneField;

        private string nameField;

        private System.Nullable<System.DateTime> offlinePdaTrialExpirationDateField;

        private bool offlinePdaTrialExpirationDateFieldSpecified;

        private System.Nullable<System.DateTime> offlineTrialExpirationDateField;

        private bool offlineTrialExpirationDateFieldSpecified;

        private string phoneField;

        private string postalCodeField;

        private string profileIdField;

        private System.Nullable<bool> receivesAdminInfoEmailsField;

        private bool receivesAdminInfoEmailsFieldSpecified;

        private System.Nullable<bool> receivesInfoEmailsField;

        private bool receivesInfoEmailsFieldSpecified;

        private string smallPhotoUrlField;

        private string stateField;

        private string streetField;

        private System.Nullable<System.DateTime> systemModstampField;

        private bool systemModstampFieldSpecified;

        private string timeZoneSidKeyField;

        private string titleField;

        private System.Nullable<bool> userPermissionsAvantgoUserField;

        private bool userPermissionsAvantgoUserFieldSpecified;

        private System.Nullable<bool> userPermissionsCallCenterAutoLoginField;

        private bool userPermissionsCallCenterAutoLoginFieldSpecified;

        private System.Nullable<bool> userPermissionsInteractionUserField;

        private bool userPermissionsInteractionUserFieldSpecified;

        private System.Nullable<bool> userPermissionsMarketingUserField;

        private bool userPermissionsMarketingUserFieldSpecified;

        private System.Nullable<bool> userPermissionsMobileUserField;

        private bool userPermissionsMobileUserFieldSpecified;

        private System.Nullable<bool> userPermissionsOfflineUserField;

        private bool userPermissionsOfflineUserFieldSpecified;

        private System.Nullable<bool> userPermissionsSFContentUserField;

        private bool userPermissionsSFContentUserFieldSpecified;

        private System.Nullable<bool> userPermissionsSupportUserField;

        private bool userPermissionsSupportUserFieldSpecified;

        private System.Nullable<bool> userPreferencesActivityRemindersPopupField;

        private bool userPreferencesActivityRemindersPopupFieldSpecified;

        private System.Nullable<bool> userPreferencesApexPagesDeveloperModeField;

        private bool userPreferencesApexPagesDeveloperModeFieldSpecified;

        private System.Nullable<bool> userPreferencesDisCommentAfterLikeEmailField;

        private bool userPreferencesDisCommentAfterLikeEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisMentionsCommentEmailField;

        private bool userPreferencesDisMentionsCommentEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisProfPostCommentEmailField;

        private bool userPreferencesDisProfPostCommentEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableAllFeedsEmailField;

        private bool userPreferencesDisableAllFeedsEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableBookmarkEmailField;

        private bool userPreferencesDisableBookmarkEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableChangeCommentEmailField;

        private bool userPreferencesDisableChangeCommentEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableFileShareNotificationsForApiField;

        private bool userPreferencesDisableFileShareNotificationsForApiFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableFollowersEmailField;

        private bool userPreferencesDisableFollowersEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableLaterCommentEmailField;

        private bool userPreferencesDisableLaterCommentEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableLikeEmailField;

        private bool userPreferencesDisableLikeEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableMentionsPostEmailField;

        private bool userPreferencesDisableMentionsPostEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableMessageEmailField;

        private bool userPreferencesDisableMessageEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableProfilePostEmailField;

        private bool userPreferencesDisableProfilePostEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesDisableSharePostEmailField;

        private bool userPreferencesDisableSharePostEmailFieldSpecified;

        private System.Nullable<bool> userPreferencesEnableAutoSubForFeedsField;

        private bool userPreferencesEnableAutoSubForFeedsFieldSpecified;

        private System.Nullable<bool> userPreferencesEventRemindersCheckboxDefaultField;

        private bool userPreferencesEventRemindersCheckboxDefaultFieldSpecified;

        private System.Nullable<bool> userPreferencesReminderSoundOffField;

        private bool userPreferencesReminderSoundOffFieldSpecified;

        private System.Nullable<bool> userPreferencesTaskRemindersCheckboxDefaultField;

        private bool userPreferencesTaskRemindersCheckboxDefaultFieldSpecified;

        private string userRoleIdField;

        private string userTypeField;

        private string usernameField;

        private string workspaceIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AboutMe
        {
            get
            {
                return this.aboutMeField;
            }
            set
            {
                this.aboutMeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AccountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CallCenterId
        {
            get
            {
                return this.callCenterIdField;
            }
            set
            {
                this.callCenterIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CommunityNickname
        {
            get
            {
                return this.communityNicknameField;
            }
            set
            {
                this.communityNicknameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ContactId
        {
            get
            {
                return this.contactIdField;
            }
            set
            {
                this.contactIdField = value;
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public User CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CreatedById
        {
            get
            {
                return this.createdByIdField;
            }
            set
            {
                this.createdByIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> CreatedDate
        {
            get
            {
                return this.createdDateField;
            }
            set
            {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedDateSpecified
        {
            get
            {
                return this.createdDateFieldSpecified;
            }
            set
            {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string DefaultGroupNotificationFrequency
        {
            get
            {
                return this.defaultGroupNotificationFrequencyField;
            }
            set
            {
                this.defaultGroupNotificationFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string DelegatedApproverId
        {
            get
            {
                return this.delegatedApproverIdField;
            }
            set
            {
                this.delegatedApproverIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string DigestFrequency
        {
            get
            {
                return this.digestFrequencyField;
            }
            set
            {
                this.digestFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Division
        {
            get
            {
                return this.divisionField;
            }
            set
            {
                this.divisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string EmailEncodingKey
        {
            get
            {
                return this.emailEncodingKeyField;
            }
            set
            {
                this.emailEncodingKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string EmployeeNumber
        {
            get
            {
                return this.employeeNumberField;
            }
            set
            {
                this.employeeNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FederationIdentifier
        {
            get
            {
                return this.federationIdentifierField;
            }
            set
            {
                this.federationIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> ForecastEnabled
        {
            get
            {
                return this.forecastEnabledField;
            }
            set
            {
                this.forecastEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForecastEnabledSpecified
        {
            get
            {
                return this.forecastEnabledFieldSpecified;
            }
            set
            {
                this.forecastEnabledFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FullPhotoUrl
        {
            get
            {
                return this.fullPhotoUrlField;
            }
            set
            {
                this.fullPhotoUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActiveSpecified
        {
            get
            {
                return this.isActiveFieldSpecified;
            }
            set
            {
                this.isActiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LanguageLocaleKey
        {
            get
            {
                return this.languageLocaleKeyField;
            }
            set
            {
                this.languageLocaleKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> LastLoginDate
        {
            get
            {
                return this.lastLoginDateField;
            }
            set
            {
                this.lastLoginDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastLoginDateSpecified
        {
            get
            {
                return this.lastLoginDateFieldSpecified;
            }
            set
            {
                this.lastLoginDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public User LastModifiedBy
        {
            get
            {
                return this.lastModifiedByField;
            }
            set
            {
                this.lastModifiedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LastModifiedById
        {
            get
            {
                return this.lastModifiedByIdField;
            }
            set
            {
                this.lastModifiedByIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> LastModifiedDate
        {
            get
            {
                return this.lastModifiedDateField;
            }
            set
            {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifiedDateSpecified
        {
            get
            {
                return this.lastModifiedDateFieldSpecified;
            }
            set
            {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> LastPasswordChangeDate
        {
            get
            {
                return this.lastPasswordChangeDateField;
            }
            set
            {
                this.lastPasswordChangeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastPasswordChangeDateSpecified
        {
            get
            {
                return this.lastPasswordChangeDateFieldSpecified;
            }
            set
            {
                this.lastPasswordChangeDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LocaleSidKey
        {
            get
            {
                return this.localeSidKeyField;
            }
            set
            {
                this.localeSidKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public User Manager
        {
            get
            {
                return this.managerField;
            }
            set
            {
                this.managerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ManagerId
        {
            get
            {
                return this.managerIdField;
            }
            set
            {
                this.managerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MobilePhone
        {
            get
            {
                return this.mobilePhoneField;
            }
            set
            {
                this.mobilePhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> OfflinePdaTrialExpirationDate
        {
            get
            {
                return this.offlinePdaTrialExpirationDateField;
            }
            set
            {
                this.offlinePdaTrialExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfflinePdaTrialExpirationDateSpecified
        {
            get
            {
                return this.offlinePdaTrialExpirationDateFieldSpecified;
            }
            set
            {
                this.offlinePdaTrialExpirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> OfflineTrialExpirationDate
        {
            get
            {
                return this.offlineTrialExpirationDateField;
            }
            set
            {
                this.offlineTrialExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfflineTrialExpirationDateSpecified
        {
            get
            {
                return this.offlineTrialExpirationDateFieldSpecified;
            }
            set
            {
                this.offlineTrialExpirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProfileId
        {
            get
            {
                return this.profileIdField;
            }
            set
            {
                this.profileIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> ReceivesAdminInfoEmails
        {
            get
            {
                return this.receivesAdminInfoEmailsField;
            }
            set
            {
                this.receivesAdminInfoEmailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceivesAdminInfoEmailsSpecified
        {
            get
            {
                return this.receivesAdminInfoEmailsFieldSpecified;
            }
            set
            {
                this.receivesAdminInfoEmailsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> ReceivesInfoEmails
        {
            get
            {
                return this.receivesInfoEmailsField;
            }
            set
            {
                this.receivesInfoEmailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceivesInfoEmailsSpecified
        {
            get
            {
                return this.receivesInfoEmailsFieldSpecified;
            }
            set
            {
                this.receivesInfoEmailsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SmallPhotoUrl
        {
            get
            {
                return this.smallPhotoUrlField;
            }
            set
            {
                this.smallPhotoUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> SystemModstamp
        {
            get
            {
                return this.systemModstampField;
            }
            set
            {
                this.systemModstampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SystemModstampSpecified
        {
            get
            {
                return this.systemModstampFieldSpecified;
            }
            set
            {
                this.systemModstampFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TimeZoneSidKey
        {
            get
            {
                return this.timeZoneSidKeyField;
            }
            set
            {
                this.timeZoneSidKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsAvantgoUser
        {
            get
            {
                return this.userPermissionsAvantgoUserField;
            }
            set
            {
                this.userPermissionsAvantgoUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsAvantgoUserSpecified
        {
            get
            {
                return this.userPermissionsAvantgoUserFieldSpecified;
            }
            set
            {
                this.userPermissionsAvantgoUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsCallCenterAutoLogin
        {
            get
            {
                return this.userPermissionsCallCenterAutoLoginField;
            }
            set
            {
                this.userPermissionsCallCenterAutoLoginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsCallCenterAutoLoginSpecified
        {
            get
            {
                return this.userPermissionsCallCenterAutoLoginFieldSpecified;
            }
            set
            {
                this.userPermissionsCallCenterAutoLoginFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsInteractionUser
        {
            get
            {
                return this.userPermissionsInteractionUserField;
            }
            set
            {
                this.userPermissionsInteractionUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsInteractionUserSpecified
        {
            get
            {
                return this.userPermissionsInteractionUserFieldSpecified;
            }
            set
            {
                this.userPermissionsInteractionUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsMarketingUser
        {
            get
            {
                return this.userPermissionsMarketingUserField;
            }
            set
            {
                this.userPermissionsMarketingUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsMarketingUserSpecified
        {
            get
            {
                return this.userPermissionsMarketingUserFieldSpecified;
            }
            set
            {
                this.userPermissionsMarketingUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsMobileUser
        {
            get
            {
                return this.userPermissionsMobileUserField;
            }
            set
            {
                this.userPermissionsMobileUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsMobileUserSpecified
        {
            get
            {
                return this.userPermissionsMobileUserFieldSpecified;
            }
            set
            {
                this.userPermissionsMobileUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsOfflineUser
        {
            get
            {
                return this.userPermissionsOfflineUserField;
            }
            set
            {
                this.userPermissionsOfflineUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsOfflineUserSpecified
        {
            get
            {
                return this.userPermissionsOfflineUserFieldSpecified;
            }
            set
            {
                this.userPermissionsOfflineUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsSFContentUser
        {
            get
            {
                return this.userPermissionsSFContentUserField;
            }
            set
            {
                this.userPermissionsSFContentUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsSFContentUserSpecified
        {
            get
            {
                return this.userPermissionsSFContentUserFieldSpecified;
            }
            set
            {
                this.userPermissionsSFContentUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPermissionsSupportUser
        {
            get
            {
                return this.userPermissionsSupportUserField;
            }
            set
            {
                this.userPermissionsSupportUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPermissionsSupportUserSpecified
        {
            get
            {
                return this.userPermissionsSupportUserFieldSpecified;
            }
            set
            {
                this.userPermissionsSupportUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesActivityRemindersPopup
        {
            get
            {
                return this.userPreferencesActivityRemindersPopupField;
            }
            set
            {
                this.userPreferencesActivityRemindersPopupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesActivityRemindersPopupSpecified
        {
            get
            {
                return this.userPreferencesActivityRemindersPopupFieldSpecified;
            }
            set
            {
                this.userPreferencesActivityRemindersPopupFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesApexPagesDeveloperMode
        {
            get
            {
                return this.userPreferencesApexPagesDeveloperModeField;
            }
            set
            {
                this.userPreferencesApexPagesDeveloperModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesApexPagesDeveloperModeSpecified
        {
            get
            {
                return this.userPreferencesApexPagesDeveloperModeFieldSpecified;
            }
            set
            {
                this.userPreferencesApexPagesDeveloperModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisCommentAfterLikeEmail
        {
            get
            {
                return this.userPreferencesDisCommentAfterLikeEmailField;
            }
            set
            {
                this.userPreferencesDisCommentAfterLikeEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisCommentAfterLikeEmailSpecified
        {
            get
            {
                return this.userPreferencesDisCommentAfterLikeEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisCommentAfterLikeEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisMentionsCommentEmail
        {
            get
            {
                return this.userPreferencesDisMentionsCommentEmailField;
            }
            set
            {
                this.userPreferencesDisMentionsCommentEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisMentionsCommentEmailSpecified
        {
            get
            {
                return this.userPreferencesDisMentionsCommentEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisMentionsCommentEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisProfPostCommentEmail
        {
            get
            {
                return this.userPreferencesDisProfPostCommentEmailField;
            }
            set
            {
                this.userPreferencesDisProfPostCommentEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisProfPostCommentEmailSpecified
        {
            get
            {
                return this.userPreferencesDisProfPostCommentEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisProfPostCommentEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableAllFeedsEmail
        {
            get
            {
                return this.userPreferencesDisableAllFeedsEmailField;
            }
            set
            {
                this.userPreferencesDisableAllFeedsEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableAllFeedsEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableAllFeedsEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableAllFeedsEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableBookmarkEmail
        {
            get
            {
                return this.userPreferencesDisableBookmarkEmailField;
            }
            set
            {
                this.userPreferencesDisableBookmarkEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableBookmarkEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableBookmarkEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableBookmarkEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableChangeCommentEmail
        {
            get
            {
                return this.userPreferencesDisableChangeCommentEmailField;
            }
            set
            {
                this.userPreferencesDisableChangeCommentEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableChangeCommentEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableChangeCommentEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableChangeCommentEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableFileShareNotificationsForApi
        {
            get
            {
                return this.userPreferencesDisableFileShareNotificationsForApiField;
            }
            set
            {
                this.userPreferencesDisableFileShareNotificationsForApiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableFileShareNotificationsForApiSpecified
        {
            get
            {
                return this.userPreferencesDisableFileShareNotificationsForApiFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableFileShareNotificationsForApiFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableFollowersEmail
        {
            get
            {
                return this.userPreferencesDisableFollowersEmailField;
            }
            set
            {
                this.userPreferencesDisableFollowersEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableFollowersEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableFollowersEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableFollowersEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableLaterCommentEmail
        {
            get
            {
                return this.userPreferencesDisableLaterCommentEmailField;
            }
            set
            {
                this.userPreferencesDisableLaterCommentEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableLaterCommentEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableLaterCommentEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableLaterCommentEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableLikeEmail
        {
            get
            {
                return this.userPreferencesDisableLikeEmailField;
            }
            set
            {
                this.userPreferencesDisableLikeEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableLikeEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableLikeEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableLikeEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableMentionsPostEmail
        {
            get
            {
                return this.userPreferencesDisableMentionsPostEmailField;
            }
            set
            {
                this.userPreferencesDisableMentionsPostEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableMentionsPostEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableMentionsPostEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableMentionsPostEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableMessageEmail
        {
            get
            {
                return this.userPreferencesDisableMessageEmailField;
            }
            set
            {
                this.userPreferencesDisableMessageEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableMessageEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableMessageEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableMessageEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableProfilePostEmail
        {
            get
            {
                return this.userPreferencesDisableProfilePostEmailField;
            }
            set
            {
                this.userPreferencesDisableProfilePostEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableProfilePostEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableProfilePostEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableProfilePostEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesDisableSharePostEmail
        {
            get
            {
                return this.userPreferencesDisableSharePostEmailField;
            }
            set
            {
                this.userPreferencesDisableSharePostEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesDisableSharePostEmailSpecified
        {
            get
            {
                return this.userPreferencesDisableSharePostEmailFieldSpecified;
            }
            set
            {
                this.userPreferencesDisableSharePostEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesEnableAutoSubForFeeds
        {
            get
            {
                return this.userPreferencesEnableAutoSubForFeedsField;
            }
            set
            {
                this.userPreferencesEnableAutoSubForFeedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesEnableAutoSubForFeedsSpecified
        {
            get
            {
                return this.userPreferencesEnableAutoSubForFeedsFieldSpecified;
            }
            set
            {
                this.userPreferencesEnableAutoSubForFeedsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesEventRemindersCheckboxDefault
        {
            get
            {
                return this.userPreferencesEventRemindersCheckboxDefaultField;
            }
            set
            {
                this.userPreferencesEventRemindersCheckboxDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesEventRemindersCheckboxDefaultSpecified
        {
            get
            {
                return this.userPreferencesEventRemindersCheckboxDefaultFieldSpecified;
            }
            set
            {
                this.userPreferencesEventRemindersCheckboxDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesReminderSoundOff
        {
            get
            {
                return this.userPreferencesReminderSoundOffField;
            }
            set
            {
                this.userPreferencesReminderSoundOffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesReminderSoundOffSpecified
        {
            get
            {
                return this.userPreferencesReminderSoundOffFieldSpecified;
            }
            set
            {
                this.userPreferencesReminderSoundOffFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> UserPreferencesTaskRemindersCheckboxDefault
        {
            get
            {
                return this.userPreferencesTaskRemindersCheckboxDefaultField;
            }
            set
            {
                this.userPreferencesTaskRemindersCheckboxDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserPreferencesTaskRemindersCheckboxDefaultSpecified
        {
            get
            {
                return this.userPreferencesTaskRemindersCheckboxDefaultFieldSpecified;
            }
            set
            {
                this.userPreferencesTaskRemindersCheckboxDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string UserRoleId
        {
            get
            {
                return this.userRoleIdField;
            }
            set
            {
                this.userRoleIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string UserType
        {
            get
            {
                return this.userTypeField;
            }
            set
            {
                this.userTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string WorkspaceId
        {
            get
            {
                return this.workspaceIdField;
            }
            set
            {
                this.workspaceIdField = value;
            }
        }
    }
    #endregion
}
