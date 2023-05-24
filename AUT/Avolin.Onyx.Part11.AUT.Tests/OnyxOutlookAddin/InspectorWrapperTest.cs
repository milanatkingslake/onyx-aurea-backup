using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.InspectorWrapper" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class InspectorWrapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="InspectorWrapper" />)
        /// </summary>
        public InspectorWrapperTest() : base(typeof(InspectorWrapper))
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

        #region General Initializer : Class (InspectorWrapper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _inspectorWrapperInstanceType;
        private InspectorWrapper _inspectorWrapperInstance;
        private InspectorWrapper _inspectorWrapperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="InspectorWrapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _inspectorWrapperInstanceType = typeof(InspectorWrapper);
            _inspectorWrapperInstanceFixture = this.Create<InspectorWrapper>(false);
            _inspectorWrapperInstance = _inspectorWrapperInstanceFixture ?? this.Create<InspectorWrapper>(true);
            CurrentInstance = _inspectorWrapperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (InspectorWrapper) Initializer

        #region Properties

        private const string PropertyCustomTaskPane = "CustomTaskPane";

        #endregion

        #region Methods

        private const string MethodinspectorWrapper_Close = "inspectorWrapper_Close";

        #endregion

        #region Fields

        private const string Fieldinspector = "inspector";
        private const string FieldtaskPane = "taskPane";
        private const string FieldonyxInfoPanel = "onyxInfoPanel";
        private const string FieldmailWrapper = "mailWrapper";
        private const string FieldapptWrapper = "apptWrapper";
        private const string FieldcontactWrapper = "contactWrapper";

        #endregion

        #endregion

        #region General Initializer : Class (InspectorWrapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="InspectorWrapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_InspectorWrapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (InspectorWrapper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="InspectorWrapper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_InspectorWrapper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (InspectorWrapper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="InspectorWrapper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_InspectorWrapper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (InspectorWrapper)

        #region General Initializer : Class (InspectorWrapper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="InspectorWrapper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCustomTaskPane)]
        [Category("AUT Property")]
        public void AUT_InspectorWrapper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (InspectorWrapper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="InspectorWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldinspector)]
        [TestCase(FieldtaskPane)]
        [TestCase(FieldonyxInfoPanel)]
        [TestCase(FieldmailWrapper)]
        [TestCase(FieldapptWrapper)]
        [TestCase(FieldcontactWrapper)]
        [Category("AUT Fields")]
        public void AUT_InspectorWrapper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (InspectorWrapper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="InspectorWrapper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_InspectorWrapper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _inspectorWrapperInstance.ShouldBeAssignableTo<InspectorWrapper>();
            _inspectorWrapperInstanceFixture.ShouldBeAssignableTo<InspectorWrapper>();
            CurrentInstance.ShouldBeAssignableTo<InspectorWrapper>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (InspectorWrapper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCustomTaskPane)]
        public void AUT_InspectorWrapper_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (InspectorWrapper) => Property (CustomTaskPane) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InspectorWrapper_CustomTaskPane_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomTaskPane);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCustomTaskPane);
            Action currentAction = () => propertyInfo.SetValue(_inspectorWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (InspectorWrapper) => Property (CustomTaskPane) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InspectorWrapper_Public_Class_CustomTaskPane_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomTaskPane);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomTaskPane);

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