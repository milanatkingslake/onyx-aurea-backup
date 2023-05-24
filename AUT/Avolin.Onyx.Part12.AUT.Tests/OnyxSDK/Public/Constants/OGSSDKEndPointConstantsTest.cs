using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Constants;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.OGSSDKEndPointConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OGSSDKEndPointConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OGSSDKEndPointConstants" />)
        /// </summary>
        public OGSSDKEndPointConstantsTest() : base(typeof(OGSSDKEndPointConstants))
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OGSSDKEndPointConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oGSSDKEndPointConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OGSSDKEndPointConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oGSSDKEndPointConstantsInstanceType = typeof(OGSSDKEndPointConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OGSSDKEndPointConstants) Initializer

        #region Fields

        private const string FieldENDPOINT_AUTHENTICATE_CHANGEPASSWORD = "ENDPOINT_AUTHENTICATE_CHANGEPASSWORD";
        private const string FieldENDPOINT_AUTHENTICATE_ESTABLISHSESSION = "ENDPOINT_AUTHENTICATE_ESTABLISHSESSION";
        private const string FieldENDPOINT_AUTHENTICATENT_ESTABLISHSESSION = "ENDPOINT_AUTHENTICATENT_ESTABLISHSESSION";
        private const string FieldENDPOINT_DICTIONARY_GETCONFIGUREDPROPERTIES = "ENDPOINT_DICTIONARY_GETCONFIGUREDPROPERTIES";
        private const string FieldENDPOINT_DICTIONARY_GETOBJECTDEFINITION = "ENDPOINT_DICTIONARY_GETOBJECTDEFINITION";
        private const string FieldENDPOINT_DICTIONARY_GETOBJECTINSTANCE = "ENDPOINT_DICTIONARY_GETOBJECTINSTANCE";
        private const string FieldENDPOINT_DICTIONARY_GETOBJECTLIST = "ENDPOINT_DICTIONARY_GETOBJECTLIST";
        private const string FieldENDPOINT_DICTIONARY_GETPROPERTYCONSTRAINTS = "ENDPOINT_DICTIONARY_GETPROPERTYCONSTRAINTS";
        private const string FieldENDPOINT_EASSERVICE_EXECUTE = "ENDPOINT_EASSERVICE_EXECUTE";
        private const string FieldENDPOINT_EASSERVICE_EXECUTEWITHCONTEXT = "ENDPOINT_EASSERVICE_EXECUTEWITHCONTEXT";
        private const string FieldENDPOINT_NATLANG_RETREIVESTRING = "ENDPOINT_NATLANG_RETREIVESTRING";
        private const string FieldENDPOINT_NATLANG_RETREIVESTRINGRANGE = "ENDPOINT_NATLANG_RETREIVESTRINGRANGE";
        private const string FieldENDPOINT_SESSION_CLEARSESSIONITEMS = "ENDPOINT_SESSION_CLEARSESSIONITEMS";
        private const string FieldENDPOINT_SESSION_ENDSESSION = "ENDPOINT_SESSION_ENDSESSION";
        private const string FieldENDPOINT_SESSION_ESTABLISHSESSION = "ENDPOINT_SESSION_ESTABLISHSESSION";
        private const string FieldENDPOINT_SESSION_GETCONTEXTXML = "ENDPOINT_SESSION_GETCONTEXTXML";
        private const string FieldENDPOINT_SESSION_GETCONTEXTXML2 = "ENDPOINT_SESSION_GETCONTEXTXML2";
        private const string FieldENDPOINT_SESSION_GETSESSIONITEM = "ENDPOINT_SESSION_GETSESSIONITEM";
        private const string FieldENDPOINT_SESSION_GETSESSIONITEMS = "ENDPOINT_SESSION_GETSESSIONITEMS";
        private const string FieldENDPOINT_SESSION_HASPERMISSION = "ENDPOINT_SESSION_HASPERMISSION";
        private const string FieldENDPOINT_SESSION_HASPERMISSIONS = "ENDPOINT_SESSION_HASPERMISSIONS";
        private const string FieldENDPOINT_SESSION_OPMLICENSESAVAILABLE = "ENDPOINT_SESSION_OPMLICENSESAVAILABLE";
        private const string FieldENDPOINT_SESSION_REMOVESESSIONITEM = "ENDPOINT_SESSION_REMOVESESSIONITEM";
        private const string FieldENDPOINT_SESSION_SETIMPERSONATION = "ENDPOINT_SESSION_SETIMPERSONATION";
        private const string FieldENDPOINT_SESSION_SETSESSIONITEM = "ENDPOINT_SESSION_SETSESSIONITEM";
        private const string FieldENDPOINT_TRANSACTION_EXECUTE = "ENDPOINT_TRANSACTION_EXECUTE";
        private const string FieldENDPOINT_TRANSACTION_EXECUTEWITHRESPONSE = "ENDPOINT_TRANSACTION_EXECUTEWITHRESPONSE";

        #endregion

        #endregion

        #region General Initializer : Class (OGSSDKEndPointConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OGSSDKEndPointConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSSDKEndPointConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OGSSDKEndPointConstants)

        #region General Initializer : Class (OGSSDKEndPointConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OGSSDKEndPointConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldENDPOINT_AUTHENTICATE_CHANGEPASSWORD)]
        [TestCase(FieldENDPOINT_AUTHENTICATE_ESTABLISHSESSION)]
        [TestCase(FieldENDPOINT_AUTHENTICATENT_ESTABLISHSESSION)]
        [TestCase(FieldENDPOINT_DICTIONARY_GETCONFIGUREDPROPERTIES)]
        [TestCase(FieldENDPOINT_DICTIONARY_GETOBJECTDEFINITION)]
        [TestCase(FieldENDPOINT_DICTIONARY_GETOBJECTINSTANCE)]
        [TestCase(FieldENDPOINT_DICTIONARY_GETOBJECTLIST)]
        [TestCase(FieldENDPOINT_DICTIONARY_GETPROPERTYCONSTRAINTS)]
        [TestCase(FieldENDPOINT_EASSERVICE_EXECUTE)]
        [TestCase(FieldENDPOINT_EASSERVICE_EXECUTEWITHCONTEXT)]
        [TestCase(FieldENDPOINT_NATLANG_RETREIVESTRING)]
        [TestCase(FieldENDPOINT_NATLANG_RETREIVESTRINGRANGE)]
        [TestCase(FieldENDPOINT_SESSION_CLEARSESSIONITEMS)]
        [TestCase(FieldENDPOINT_SESSION_ENDSESSION)]
        [TestCase(FieldENDPOINT_SESSION_ESTABLISHSESSION)]
        [TestCase(FieldENDPOINT_SESSION_GETCONTEXTXML)]
        [TestCase(FieldENDPOINT_SESSION_GETCONTEXTXML2)]
        [TestCase(FieldENDPOINT_SESSION_GETSESSIONITEM)]
        [TestCase(FieldENDPOINT_SESSION_GETSESSIONITEMS)]
        [TestCase(FieldENDPOINT_SESSION_HASPERMISSION)]
        [TestCase(FieldENDPOINT_SESSION_HASPERMISSIONS)]
        [TestCase(FieldENDPOINT_SESSION_OPMLICENSESAVAILABLE)]
        [TestCase(FieldENDPOINT_SESSION_REMOVESESSIONITEM)]
        [TestCase(FieldENDPOINT_SESSION_SETIMPERSONATION)]
        [TestCase(FieldENDPOINT_SESSION_SETSESSIONITEM)]
        [TestCase(FieldENDPOINT_TRANSACTION_EXECUTE)]
        [TestCase(FieldENDPOINT_TRANSACTION_EXECUTEWITHRESPONSE)]
        [Category("AUT Fields")]
        public void AUT_OGSSDKEndPointConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OGSSDKEndPointConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OGSSDKEndPointConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSSDKEndPointConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _oGSSDKEndPointConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}