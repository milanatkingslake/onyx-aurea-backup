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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.MediationProfile" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MediationProfileTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MediationProfile" />)
        /// </summary>
        public MediationProfileTest() : base(typeof(MediationProfile))
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

        #region General Initializer : Class (MediationProfile) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _mediationProfileInstanceType;
        private MediationProfile _mediationProfileInstance;
        private MediationProfile _mediationProfileInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MediationProfile" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _mediationProfileInstanceType = typeof(MediationProfile);
            _mediationProfileInstanceFixture = this.Create<MediationProfile>(false);
            _mediationProfileInstance = _mediationProfileInstanceFixture ?? this.Create<MediationProfile>(true);
            CurrentInstance = _mediationProfileInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MediationProfile) Initializer

        #region Properties

        private const string PropertyId = "Id";
        private const string PropertyIsSynchronous = "IsSynchronous";
        private const string PropertyName = "Name";
        private const string PropertyMediationBrokers = "MediationBrokers";

        #endregion

        #endregion

        #region General Initializer : Class (MediationProfile) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MediationProfile" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MediationProfile_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MediationProfile) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MediationProfile" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MediationProfile_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MediationProfile) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MediationProfile" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MediationProfile_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MediationProfile)

        #region General Initializer : Class (MediationProfile) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MediationProfile" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyId)]
        [TestCase(PropertyIsSynchronous)]
        [TestCase(PropertyName)]
        [TestCase(PropertyMediationBrokers)]
        [Category("AUT Property")]
        public void AUT_MediationProfile_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MediationProfile) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MediationProfile" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MediationProfile_Is_Instance_Present_Test()
        {
            // Assert
            _mediationProfileInstanceType.ShouldNotBeNull();
            _mediationProfileInstance.ShouldNotBeNull();
            _mediationProfileInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MediationProfile) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MediationProfile" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MediationProfile_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _mediationProfileInstance.ShouldBeAssignableTo<MediationProfile>();
            _mediationProfileInstanceFixture.ShouldBeAssignableTo<MediationProfile>();
            CurrentInstance.ShouldBeAssignableTo<MediationProfile>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MediationProfile) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MediationProfile_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MediationProfile instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MediationProfile) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyId)]
        [TestCase(PropertyIsSynchronous)]
        [TestCase(PropertyName)]
        [TestCase(PropertyMediationBrokers)]
        public void AUT_MediationProfile_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MediationProfile) => Property (Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MediationProfile_Public_Class_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (MediationProfile) => Property (IsSynchronous) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MediationProfile_Public_Class_IsSynchronous_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSynchronous);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSynchronous);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MediationProfile) => Property (MediationBrokers) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MediationProfile_Public_Class_MediationBrokers_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMediationBrokers);
            var propertyInfo = this.GetPropertyInfo(PropertyMediationBrokers);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MediationProfile) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MediationProfile_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyName);

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