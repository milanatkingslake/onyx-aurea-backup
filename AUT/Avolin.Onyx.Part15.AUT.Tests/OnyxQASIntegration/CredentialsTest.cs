using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxQASIntegration;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxQASIntegration
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.Credentials" />)
    ///     and namespace <see cref="OnyxQASIntegration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CredentialsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="CredentialsNonPublicTypeName" />) using
        ///     Using a public type <see cref="SearchAddress" /> to
        ///     create a non-public type.
        /// </summary>
        public CredentialsTest() : base(publicType: typeof(SearchAddress), classNameWithNamespace: CredentialsNonPublicTypeName)
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

        private Type _credentialsInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string CredentialsNonPublicTypeName = "OnyxQASIntegration.Credentials";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _credentialsInstance;
        private object _credentialsInstanceFixture;

        #region General Initializer : Class (Credentials) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Credentials" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _credentialsInstanceFixture = this.CreateNonPublicType(CredentialsNonPublicTypeName);
            _credentialsInstance = _credentialsInstanceFixture;
            CurrentInstance = _credentialsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Credentials) Initializer

        #region Methods

        private const string MethodGetCredentials = "GetCredentials";
        private const string MethodDecryptedPassword = "DecryptedPassword";

        #endregion

        #region Fields

        private const string Fieldpassphrase = "passphrase";
        private const string FieldUsername = "Username";
        private const string FieldPassword = "Password";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Credentials)

        #region General Initializer : Class (Credentials) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Credentials" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodGetCredentials, 0)]
        [TestCase(MethodDecryptedPassword, 0)]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Credentials_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (Credentials) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Credentials" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Credentials_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Credentials) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Credentials" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldpassphrase)]
        [TestCase(FieldUsername)]
        [TestCase(FieldPassword)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_Credentials_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Credentials) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Credentials" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Credentials_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}