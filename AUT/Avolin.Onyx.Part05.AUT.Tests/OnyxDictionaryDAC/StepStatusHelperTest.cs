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
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.StepStatusHelper" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepStatusHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="StepStatusHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="Dictionary" /> to
        ///     create a non-public type.
        /// </summary>
        public StepStatusHelperTest() : base(publicType: typeof(Dictionary), classNameWithNamespace: StepStatusHelperNonPublicTypeName)
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

        private Type _stepStatusHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string StepStatusHelperNonPublicTypeName = "OnyxDictionaryDAC.StepStatusHelper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _stepStatusHelperInstance;
        private object _stepStatusHelperInstanceFixture;

        #region General Initializer : Class (StepStatusHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="StepStatusHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepStatusHelperInstanceFixture = this.CreateNonPublicType(StepStatusHelperNonPublicTypeName);
            _stepStatusHelperInstance = _stepStatusHelperInstanceFixture;
            CurrentInstance = _stepStatusHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepStatusHelper) Initializer

        #region Properties

        private const string PropertyDOM = "DOM";
        private const string PropertyTopNode = "TopNode";
        private const string PropertyXML = "XML";
        private const string PropertyStatusType = "StatusType";

        #endregion

        #region Methods

        private const string MethodAttach = "Attach";
        private const string MethodDetach = "Detach";
        private const string MethodAddMessage = "AddMessage";

        #endregion

        #region Fields

        private const string FieldmoDOMHelper = "moDOMHelper";
        private const string FieldUNIVERSAL_APPSERVER_DATE_FORMAT = "UNIVERSAL_APPSERVER_DATE_FORMAT";
        private const string FieldUNIVERSAL_APPSERVER_TIME_FORMAT = "UNIVERSAL_APPSERVER_TIME_FORMAT";
        private const string FieldUNIVERSAL_APPSERVER_DATETIME_FORMAT = "UNIVERSAL_APPSERVER_DATETIME_FORMAT";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (StepStatusHelper)

        #region General Initializer : Class (StepStatusHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StepStatusHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAttach, 0)]
        [TestCase(MethodDetach, 0)]
        [TestCase(MethodAddMessage, 0)]
        [Category("AUT Explore")]
        public void AUT_StepStatusHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (StepStatusHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepStatusHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepStatusHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (StepStatusHelper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepStatusHelper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDOM)]
        [TestCase(PropertyTopNode)]
        [TestCase(PropertyXML)]
        [TestCase(PropertyStatusType)]
        [Category("AUT Property")]
        public void AUT_StepStatusHelper_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (StepStatusHelper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepStatusHelper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepStatusHelper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (StepStatusHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepStatusHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldmoDOMHelper)]
        [TestCase(FieldUNIVERSAL_APPSERVER_DATE_FORMAT)]
        [TestCase(FieldUNIVERSAL_APPSERVER_TIME_FORMAT)]
        [TestCase(FieldUNIVERSAL_APPSERVER_DATETIME_FORMAT)]
        [Category("AUT Fields")]
        public void AUT_StepStatusHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepStatusHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepStatusHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepStatusHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepStatusHelper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDOM)]
        [TestCase(PropertyTopNode)]
        [TestCase(PropertyXML)]
        [TestCase(PropertyStatusType)]
        public void AUT_StepStatusHelper_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (StepStatusHelper) => Property (StatusType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepStatusHelper_Public_Class_StatusType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusType);
            var propertyInfo = this.GetPropertyInfo(PropertyStatusType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepStatusHelper) => Property (TopNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepStatusHelper_TopNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTopNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTopNode);
            Action currentAction = () => propertyInfo.SetValue(_stepStatusHelperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepStatusHelper) => Property (TopNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepStatusHelper_Public_Class_TopNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTopNode);
            var propertyInfo = this.GetPropertyInfo(PropertyTopNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepStatusHelper) => Property (XML) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepStatusHelper_Public_Class_XML_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyXML);
            var propertyInfo = this.GetPropertyInfo(PropertyXML);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}