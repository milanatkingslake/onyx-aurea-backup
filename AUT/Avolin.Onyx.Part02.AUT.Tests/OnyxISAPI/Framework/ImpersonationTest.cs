using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Framework;
using Shouldly;
using SortOrder = OnyxISAPI.Framework.SortOrder;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Framework
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Framework.Impersonation" />)
    ///     and namespace <see cref="OnyxISAPI.Framework"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ImpersonationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ImpersonationNonPublicTypeName" />) using
        ///     Using a public type <see cref="SortOrder" /> to
        ///     create a non-public type.
        /// </summary>
        public ImpersonationTest() : base(publicType: typeof(SortOrder), classNameWithNamespace: ImpersonationNonPublicTypeName)
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

        private Type _impersonationInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ImpersonationNonPublicTypeName = "OnyxISAPI.Framework.Impersonation";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _impersonationInstance;
        private object _impersonationInstanceFixture;

        #region General Initializer : Class (Impersonation) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Impersonation" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _impersonationInstanceFixture = this.CreateNonPublicType(ImpersonationNonPublicTypeName);
            _impersonationInstance = _impersonationInstanceFixture;
            CurrentInstance = _impersonationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Impersonation) Initializer

        #region Methods

        private const string MethodLogonUser = "LogonUser";
        
        private const string MethodImpersonate = "Impersonate";
        private const string MethodUndo = "Undo";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        private const string Field_domain = "_domain";
        private const string Field_username = "_username";
        private const string Field_password = "_password";
        private const string FieldtokenHandle = "tokenHandle";
        private const string FieldimpersonatedUser = "impersonatedUser";
        private const string FieldWA_Logon_Type = "WA_Logon_Type";
        private const string FieldWA_Logon_Provider = "WA_Logon_Provider";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Impersonation)

        #region General Initializer : Class (Impersonation) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Impersonation" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogonUser, 0)]
        [TestCase(MethodImpersonate, 0)]
        [TestCase(MethodUndo, 0)]
        [Category("AUT Explore")]
        public void AUT_Impersonation_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Impersonation) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Impersonation" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Impersonation_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Impersonation) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Impersonation" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_domain)]
        [TestCase(Field_username)]
        [TestCase(Field_password)]
        [TestCase(FieldtokenHandle)]
        [TestCase(FieldimpersonatedUser)]
        [TestCase(FieldWA_Logon_Type)]
        [TestCase(FieldWA_Logon_Provider)]
        [Category("AUT Fields")]
        public void AUT_Impersonation_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Impersonation) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Impersonation" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Impersonation_Explore_Reflection_Based_NonListed_Fields_Test()
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