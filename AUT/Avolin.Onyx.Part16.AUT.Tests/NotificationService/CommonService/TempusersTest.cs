using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NotificationService.CommonService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.CommonService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.CommonService.Tempusers" />)
    ///     and namespace <see cref="NotificationService.CommonService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TempusersTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Tempusers" />)
        /// </summary>
        public TempusersTest() : base(typeof(Tempusers))
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

        #region General Initializer : Class (Tempusers) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _tempusersInstanceType;
        private Tempusers _tempusersInstance;
        private Tempusers _tempusersInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Tempusers" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _tempusersInstanceType = typeof(Tempusers);
            _tempusersInstanceFixture = this.Create<Tempusers>(false);
            _tempusersInstance = _tempusersInstanceFixture ?? this.Create<Tempusers>(true);
            CurrentInstance = _tempusersInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Tempusers) Initializer

        #region Properties

        private const string Propertyuser_id = "user_id";
        private const string Propertysite_id = "site_id";
        private const string Propertyuser_name = "user_name";
        private const string Propertylanguage_code = "language_code";
        private const string Propertyemail_alias = "email_alias";
        private const string Propertyrecord_status = "record_status";

        #endregion

        #endregion

        #region General Initializer : Class (Tempusers) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Tempusers" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Tempusers_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Tempusers) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Tempusers" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Tempusers_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Tempusers) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Tempusers" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Tempusers_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Tempusers)

        #region General Initializer : Class (Tempusers) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Tempusers" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyuser_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyuser_name)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertyemail_alias)]
        [TestCase(Propertyrecord_status)]
        [Category("AUT Property")]
        public void AUT_Tempusers_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Tempusers) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Tempusers" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Tempusers_Is_Instance_Present_Test()
        {
            // Assert
            _tempusersInstanceType.ShouldNotBeNull();
            _tempusersInstance.ShouldNotBeNull();
            _tempusersInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Tempusers) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Tempusers" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Tempusers_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _tempusersInstance.ShouldBeAssignableTo<Tempusers>();
            _tempusersInstanceFixture.ShouldBeAssignableTo<Tempusers>();
            CurrentInstance.ShouldBeAssignableTo<Tempusers>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Tempusers) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Tempusers_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Tempusers instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (Tempusers) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Tempusers_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var uId = this.CreateType<string>();
            var sId = this.CreateType<int>();
            var uName = this.CreateType<string>();
            var lanCode = this.CreateType<string>();
            var eId = this.CreateType<string>();
            var status = this.CreateType<string>();
            Tempusers instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Tempusers(uId, sId, uName, lanCode, eId, status);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _tempusersInstance.ShouldNotBeNull();
            _tempusersInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Tempusers>();
        }

        #endregion

        #region General Constructor : Class (Tempusers) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Tempusers_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var uId = this.CreateType<string>();
            var sId = this.CreateType<int>();
            var uName = this.CreateType<string>();
            var lanCode = this.CreateType<string>();
            var eId = this.CreateType<string>();
            var status = this.CreateType<string>();
            Tempusers instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Tempusers(uId, sId, uName, lanCode, eId, status);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _tempusersInstance.ShouldNotBeNull();
            _tempusersInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (Tempusers) instance created

        /// <summary>
        ///     Class (<see cref="Tempusers" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Tempusers_Is_Created_Test()
        {
            // Assert
            _tempusersInstance.ShouldNotBeNull();
            _tempusersInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Tempusers) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="Tempusers" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_Tempusers_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Tempusers) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="Tempusers" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Tempusers_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Tempusers) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Tempusers" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Tempusers_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodTempusersParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTempusersParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Tempusers) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Tempusers" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Tempusers_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTempusersParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTempusersParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Tempusers) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyuser_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyuser_name)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertyemail_alias)]
        [TestCase(Propertyrecord_status)]
        public void AUT_Tempusers_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Tempusers) => Property (email_alias) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Tempusers_Public_Class_email_alias_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyemail_alias);
            var propertyInfo = this.GetPropertyInfo(Propertyemail_alias);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Tempusers) => Property (language_code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Tempusers_Public_Class_language_code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylanguage_code);
            var propertyInfo = this.GetPropertyInfo(Propertylanguage_code);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Tempusers) => Property (record_status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Tempusers_Public_Class_record_status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyrecord_status);
            var propertyInfo = this.GetPropertyInfo(Propertyrecord_status);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Tempusers) => Property (site_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Tempusers_Public_Class_site_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysite_id);
            var propertyInfo = this.GetPropertyInfo(Propertysite_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Tempusers) => Property (user_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Tempusers_Public_Class_user_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuser_id);
            var propertyInfo = this.GetPropertyInfo(Propertyuser_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Tempusers) => Property (user_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Tempusers_Public_Class_user_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuser_name);
            var propertyInfo = this.GetPropertyInfo(Propertyuser_name);

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