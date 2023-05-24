using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.ScriptSessionOwnerModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptSessionOwnerModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionOwnerModel" />)
        /// </summary>
        public ScriptSessionOwnerModelTest() : base(typeof(ScriptSessionOwnerModel))
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

        #region General Initializer : Class (ScriptSessionOwnerModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionOwnerModelInstanceType;
        private ScriptSessionOwnerModel _scriptSessionOwnerModelInstance;
        private ScriptSessionOwnerModel _scriptSessionOwnerModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionOwnerModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionOwnerModelInstanceType = typeof(ScriptSessionOwnerModel);
            _scriptSessionOwnerModelInstanceFixture = this.Create<ScriptSessionOwnerModel>(false);
            _scriptSessionOwnerModelInstance = _scriptSessionOwnerModelInstanceFixture ?? this.Create<ScriptSessionOwnerModel>(true);
            CurrentInstance = _scriptSessionOwnerModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionOwnerModel) Initializer

        #region Properties

        private const string PropertyOwnerType = "OwnerType";
        private const string PropertyOwnerId = "OwnerId";
        private const string PropertyOwnerSecondaryId = "OwnerSecondaryId";
        private const string PropertyOwnerName = "OwnerName";
        private const string PropertyOwnerSubType = "OwnerSubType";
        private const string PropertyPrimaryContactId = "PrimaryContactId";
        private const string PropertyPrimaryContactName = "PrimaryContactName";
        private const string PropertyPrimaryContactType = "PrimaryContactType";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptSessionOwnerModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptSessionOwnerModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionOwnerModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionOwnerModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptSessionOwnerModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionOwnerModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionOwnerModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionOwnerModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionOwnerModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionOwnerModel)

        #region General Initializer : Class (ScriptSessionOwnerModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptSessionOwnerModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOwnerType)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerSecondaryId)]
        [TestCase(PropertyOwnerName)]
        [TestCase(PropertyOwnerSubType)]
        [TestCase(PropertyPrimaryContactId)]
        [TestCase(PropertyPrimaryContactName)]
        [TestCase(PropertyPrimaryContactType)]
        [Category("AUT Property")]
        public void AUT_ScriptSessionOwnerModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptSessionOwnerModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionOwnerModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionOwnerModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptSessionOwnerModelInstanceType.ShouldNotBeNull();
            _scriptSessionOwnerModelInstance.ShouldNotBeNull();
            _scriptSessionOwnerModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptSessionOwnerModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptSessionOwnerModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionOwnerModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptSessionOwnerModelInstance.ShouldBeAssignableTo<ScriptSessionOwnerModel>();
            _scriptSessionOwnerModelInstanceFixture.ShouldBeAssignableTo<ScriptSessionOwnerModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptSessionOwnerModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptSessionOwnerModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionOwnerModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptSessionOwnerModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOwnerType)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerSecondaryId)]
        [TestCase(PropertyOwnerName)]
        [TestCase(PropertyOwnerSubType)]
        [TestCase(PropertyPrimaryContactId)]
        [TestCase(PropertyPrimaryContactName)]
        [TestCase(PropertyPrimaryContactType)]
        public void AUT_ScriptSessionOwnerModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (OwnerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_OwnerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (OwnerName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_OwnerName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerName);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (OwnerSecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_OwnerSecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerSecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerSecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (OwnerSubType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_OwnerSubType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerSubType);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerSubType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (OwnerType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_OwnerType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerType);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (PrimaryContactId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_PrimaryContactId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryContactId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryContactId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (PrimaryContactName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_PrimaryContactName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryContactName);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryContactName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionOwnerModel) => Property (PrimaryContactType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionOwnerModel_Public_Class_PrimaryContactType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryContactType);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryContactType);

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