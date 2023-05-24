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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.ReferenceLookupModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ReferenceLookupModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReferenceLookupModel" />)
        /// </summary>
        public ReferenceLookupModelTest() : base(typeof(ReferenceLookupModel))
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

        #region General Initializer : Class (ReferenceLookupModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _referenceLookupModelInstanceType;
        private ReferenceLookupModel _referenceLookupModelInstance;
        private ReferenceLookupModel _referenceLookupModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReferenceLookupModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _referenceLookupModelInstanceType = typeof(ReferenceLookupModel);
            _referenceLookupModelInstanceFixture = this.Create<ReferenceLookupModel>(false);
            _referenceLookupModelInstance = _referenceLookupModelInstanceFixture ?? this.Create<ReferenceLookupModel>(true);
            CurrentInstance = _referenceLookupModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupModel) Initializer

        #region Properties

        private const string PropertyReferenceId = "ReferenceId";
        private const string PropertyParameterId = "ParameterId";
        private const string PropertyParentId = "ParentId";
        private const string PropertyDescription = "Description";
        private const string PropertyExtraData = "ExtraData";
        private const string PropertySequenceNumber = "SequenceNumber";
        private const string PropertyCharacterCode = "CharacterCode";

        #endregion

        #endregion

        #region General Initializer : Class (ReferenceLookupModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReferenceLookupModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ReferenceLookupModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ReferenceLookupModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ReferenceLookupModel)

        #region General Initializer : Class (ReferenceLookupModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ReferenceLookupModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyReferenceId)]
        [TestCase(PropertyParameterId)]
        [TestCase(PropertyParentId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyExtraData)]
        [TestCase(PropertySequenceNumber)]
        [TestCase(PropertyCharacterCode)]
        [Category("AUT Property")]
        public void AUT_ReferenceLookupModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ReferenceLookupModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReferenceLookupModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupModel_Is_Instance_Present_Test()
        {
            // Assert
            _referenceLookupModelInstanceType.ShouldNotBeNull();
            _referenceLookupModelInstance.ShouldNotBeNull();
            _referenceLookupModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReferenceLookupModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReferenceLookupModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _referenceLookupModelInstance.ShouldBeAssignableTo<ReferenceLookupModel>();
            _referenceLookupModelInstanceFixture.ShouldBeAssignableTo<ReferenceLookupModel>();
            CurrentInstance.ShouldBeAssignableTo<ReferenceLookupModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ReferenceLookupModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ReferenceLookupModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReferenceLookupModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ReferenceLookupModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyReferenceId)]
        [TestCase(PropertyParameterId)]
        [TestCase(PropertyParentId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyExtraData)]
        [TestCase(PropertySequenceNumber)]
        [TestCase(PropertyCharacterCode)]
        public void AUT_ReferenceLookupModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ReferenceLookupModel) => Property (CharacterCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReferenceLookupModel_Public_Class_CharacterCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCharacterCode);
            var propertyInfo = this.GetPropertyInfo(PropertyCharacterCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReferenceLookupModel) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReferenceLookupModel_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReferenceLookupModel) => Property (ExtraData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReferenceLookupModel_Public_Class_ExtraData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtraData);
            var propertyInfo = this.GetPropertyInfo(PropertyExtraData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReferenceLookupModel) => Property (ParameterId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReferenceLookupModel_Public_Class_ParameterId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterId);
            var propertyInfo = this.GetPropertyInfo(PropertyParameterId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReferenceLookupModel) => Property (ParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReferenceLookupModel_Public_Class_ParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParentId);
            var propertyInfo = this.GetPropertyInfo(PropertyParentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReferenceLookupModel) => Property (ReferenceId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReferenceLookupModel_Public_Class_ReferenceId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferenceId);
            var propertyInfo = this.GetPropertyInfo(PropertyReferenceId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReferenceLookupModel) => Property (SequenceNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReferenceLookupModel_Public_Class_SequenceNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySequenceNumber);
            var propertyInfo = this.GetPropertyInfo(PropertySequenceNumber);

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