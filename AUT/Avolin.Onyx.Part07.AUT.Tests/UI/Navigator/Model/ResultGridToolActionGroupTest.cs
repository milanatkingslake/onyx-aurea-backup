using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ResultGridToolActionGroup" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResultGridToolActionGroupTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResultGridToolActionGroup" />)
        /// </summary>
        public ResultGridToolActionGroupTest() : base(typeof(ResultGridToolActionGroup))
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

        #region General Initializer : Class (ResultGridToolActionGroup) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _resultGridToolActionGroupInstanceType;
        private ResultGridToolActionGroup _resultGridToolActionGroupInstance;
        private ResultGridToolActionGroup _resultGridToolActionGroupInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResultGridToolActionGroup" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resultGridToolActionGroupInstanceType = typeof(ResultGridToolActionGroup);
            _resultGridToolActionGroupInstanceFixture = this.Create<ResultGridToolActionGroup>(false);
            _resultGridToolActionGroupInstance = _resultGridToolActionGroupInstanceFixture ?? this.Create<ResultGridToolActionGroup>(true);
            CurrentInstance = _resultGridToolActionGroupInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResultGridToolActionGroup) Initializer

        #region Properties

        private const string PropertyId = "Id";
        private const string PropertyReferenceName = "ReferenceName";
        private const string PropertyToolTip = "ToolTip";
        private const string PropertyIcon = "Icon";
        private const string PropertyEntityId = "EntityId";
        private const string PropertyMethodName = "MethodName";
        private const string PropertyResourceName = "ResourceName";
        private const string PropertyItems = "Items";

        #endregion

        #endregion

        #region General Initializer : Class (ResultGridToolActionGroup) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionGroup" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridToolActionGroup_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGridToolActionGroup) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionGroup" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridToolActionGroup_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGridToolActionGroup) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionGroup" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridToolActionGroup_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResultGridToolActionGroup)

        #region General Initializer : Class (ResultGridToolActionGroup) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionGroup" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyId)]
        [TestCase(PropertyReferenceName)]
        [TestCase(PropertyToolTip)]
        [TestCase(PropertyIcon)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyItems)]
        [Category("AUT Property")]
        public void AUT_ResultGridToolActionGroup_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ResultGridToolActionGroup) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionGroup" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGridToolActionGroup_Is_Instance_Present_Test()
        {
            // Assert
            _resultGridToolActionGroupInstanceType.ShouldNotBeNull();
            _resultGridToolActionGroupInstance.ShouldNotBeNull();
            _resultGridToolActionGroupInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResultGridToolActionGroup) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionGroup" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGridToolActionGroup_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _resultGridToolActionGroupInstance.ShouldBeAssignableTo<ResultGridToolActionGroup>();
            _resultGridToolActionGroupInstanceFixture.ShouldBeAssignableTo<ResultGridToolActionGroup>();
            CurrentInstance.ShouldBeAssignableTo<ResultGridToolActionGroup>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResultGridToolActionGroup) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultGridToolActionGroup_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResultGridToolActionGroup instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyId)]
        [TestCase(PropertyReferenceName)]
        [TestCase(PropertyToolTip)]
        [TestCase(PropertyIcon)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyItems)]
        public void AUT_ResultGridToolActionGroup_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (EntityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_EntityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityId);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (Icon) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_Icon_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIcon);
            var propertyInfo = this.GetPropertyInfo(PropertyIcon);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var propertyInfo = this.GetPropertyInfo(PropertyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (Items) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_Items_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItems);
            var propertyInfo = this.GetPropertyInfo(PropertyItems);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (MethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_MethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertyMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (ReferenceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_ReferenceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferenceName);
            var propertyInfo = this.GetPropertyInfo(PropertyReferenceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (ResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_ResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionGroup) => Property (ToolTip) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionGroup_Public_Class_ToolTip_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip);

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