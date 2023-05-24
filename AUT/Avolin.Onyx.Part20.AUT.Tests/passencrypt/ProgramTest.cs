using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using passencrypt;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.passencrypt
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="passencrypt.Program" />)
    ///     and namespace <see cref="passencrypt"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ProgramTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ProgramNonPublicTypeName" />) using
        ///     Using a public type <see cref="Display" /> to
        ///     create a non-public type.
        /// </summary>
        public ProgramTest() : base(publicType: typeof(Display), classNameWithNamespace: ProgramNonPublicTypeName)
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

        private Type _programInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ProgramNonPublicTypeName = "passencrypt.Program";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _programInstance;
        private object _programInstanceFixture;

        #region General Initializer : Class (Program) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Program" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _programInstanceFixture = this.CreateNonPublicType(ProgramNonPublicTypeName);
            _programInstance = _programInstanceFixture;
            CurrentInstance = _programInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Program) Initializer

        #region Methods

        private const string MethodMain = "Main";
        private const string MethodEncryptText = "EncryptText";
        private const string MethodDecryptText = "DecryptText";
        private const string MethodCreateKeys = "CreateKeys";
        private const string MethodStringContainsIllegalChars = "StringContainsIllegalChars";

        #endregion

        #region Fields

        private const string FieldargumentCollection = "argumentCollection";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Program)

        #region General Initializer : Class (Program) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMain, 0)]
        [TestCase(MethodEncryptText, 0)]
        [TestCase(MethodDecryptText, 0)]
        [TestCase(MethodCreateKeys, 0)]
        [TestCase(MethodStringContainsIllegalChars, 0)]
        [Category("AUT Explore")]
        public void AUT_Program_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Program) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Program_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Program) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldargumentCollection)]
        [Category("AUT Fields")]
        public void AUT_Program_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Program) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Program_Explore_Reflection_Based_NonListed_Fields_Test()
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