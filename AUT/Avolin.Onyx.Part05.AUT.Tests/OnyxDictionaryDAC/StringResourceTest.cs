using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxDictionaryDAC;
using Shouldly;

namespace Avolin.Onyx.Part05.AUT.Tests.OnyxDictionaryDAC
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.StringResource" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StringResourceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="StringResourceNonPublicTypeName" />) using
        ///     Using a public type <see cref="Dictionary" /> to
        ///     create a non-public type.
        /// </summary>
        public StringResourceTest() : base(publicType: typeof(Dictionary), classNameWithNamespace: StringResourceNonPublicTypeName)
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

        private Type _stringResourceInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string StringResourceNonPublicTypeName = "OnyxDictionaryDAC.StringResource";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _stringResourceInstance;
        private object _stringResourceInstanceFixture;

        #region General Initializer : Class (StringResource) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="StringResource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stringResourceInstanceFixture = this.CreateNonPublicType(StringResourceNonPublicTypeName);
            _stringResourceInstance = _stringResourceInstanceFixture;
            CurrentInstance = _stringResourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StringResource) Initializer

        #region Methods

        private const string MethodGetString = "GetString";

        #endregion

        #region Fields

        private const string FieldmhInst = "mhInst";
        private const string FieldmbTriedLoad = "mbTriedLoad";
        private const string Fieldresmgr = "resmgr";
        private const string FieldlocalisationAssembly = "localisationAssembly";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (StringResource)

        #region General Initializer : Class (StringResource) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StringResource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetString, 0)]
        [Category("AUT Explore")]
        public void AUT_StringResource_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (StringResource) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StringResource" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StringResource_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (StringResource) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StringResource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldmhInst)]
        [TestCase(FieldmbTriedLoad)]
        [TestCase(Fieldresmgr)]
        [TestCase(FieldlocalisationAssembly)]
        [Category("AUT Fields")]
        public void AUT_StringResource_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StringResource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StringResource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StringResource_Explore_Reflection_Based_NonListed_Fields_Test()
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