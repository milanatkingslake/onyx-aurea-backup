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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ResultGridToolActionItem" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResultGridToolActionItemTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResultGridToolActionItem" />)
        /// </summary>
        public ResultGridToolActionItemTest() : base(typeof(ResultGridToolActionItem))
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

        #region General Initializer : Class (ResultGridToolActionItem) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _resultGridToolActionItemInstanceType;
        private ResultGridToolActionItem _resultGridToolActionItemInstance;
        private ResultGridToolActionItem _resultGridToolActionItemInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResultGridToolActionItem" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resultGridToolActionItemInstanceType = typeof(ResultGridToolActionItem);
            _resultGridToolActionItemInstanceFixture = this.Create<ResultGridToolActionItem>(false);
            _resultGridToolActionItemInstance = _resultGridToolActionItemInstanceFixture ?? this.Create<ResultGridToolActionItem>(true);
            CurrentInstance = _resultGridToolActionItemInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResultGridToolActionItem) Initializer

        #region Properties

        private const string PropertyGroupId = "GroupId";
        private const string PropertyReferenceName = "ReferenceName";
        private const string PropertyItemText = "ItemText";
        private const string PropertyIcon = "Icon";
        private const string PropertyMethodName = "MethodName";
        private const string PropertyResourceName = "ResourceName";

        #endregion

        #endregion

        #region General Initializer : Class (ResultGridToolActionItem) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionItem" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridToolActionItem_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGridToolActionItem) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionItem" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridToolActionItem_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGridToolActionItem) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionItem" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridToolActionItem_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResultGridToolActionItem)

        #region General Initializer : Class (ResultGridToolActionItem) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionItem" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyGroupId)]
        [TestCase(PropertyReferenceName)]
        [TestCase(PropertyItemText)]
        [TestCase(PropertyIcon)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyResourceName)]
        [Category("AUT Property")]
        public void AUT_ResultGridToolActionItem_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ResultGridToolActionItem) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGridToolActionItem_Is_Instance_Present_Test()
        {
            // Assert
            _resultGridToolActionItemInstanceType.ShouldNotBeNull();
            _resultGridToolActionItemInstance.ShouldNotBeNull();
            _resultGridToolActionItemInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResultGridToolActionItem) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResultGridToolActionItem" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGridToolActionItem_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _resultGridToolActionItemInstance.ShouldBeAssignableTo<ResultGridToolActionItem>();
            _resultGridToolActionItemInstanceFixture.ShouldBeAssignableTo<ResultGridToolActionItem>();
            CurrentInstance.ShouldBeAssignableTo<ResultGridToolActionItem>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResultGridToolActionItem) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultGridToolActionItem_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResultGridToolActionItem instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ResultGridToolActionItem) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyGroupId)]
        [TestCase(PropertyReferenceName)]
        [TestCase(PropertyItemText)]
        [TestCase(PropertyIcon)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyResourceName)]
        public void AUT_ResultGridToolActionItem_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ResultGridToolActionItem) => Property (GroupId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionItem_Public_Class_GroupId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGroupId);
            var propertyInfo = this.GetPropertyInfo(PropertyGroupId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionItem) => Property (Icon) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionItem_Public_Class_Icon_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ResultGridToolActionItem) => Property (ItemText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionItem_Public_Class_ItemText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemText);
            var propertyInfo = this.GetPropertyInfo(PropertyItemText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGridToolActionItem) => Property (MethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionItem_Public_Class_MethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ResultGridToolActionItem) => Property (ReferenceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionItem_Public_Class_ReferenceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ResultGridToolActionItem) => Property (ResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGridToolActionItem_Public_Class_ResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}