using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="AbstractEntity" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\AbstractEntity.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AbstractEntityTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AbstractEntity" />)
        /// </summary>
        public AbstractEntityTest() : base(typeof(AbstractEntity))
        { }

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

        #region General Initializer : Class (AbstractEntity) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _abstractEntityInstanceType;
        private AbstractEntity _abstractEntityInstance;
        private AbstractEntity _abstractEntityInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AbstractEntity" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _abstractEntityInstanceType = typeof(AbstractEntity);
            _abstractEntityInstanceFixture = this.Create<AbstractEntity>(false);
            _abstractEntityInstance = _abstractEntityInstanceFixture ?? this.Create<AbstractEntity>(true);
            CurrentInstance = _abstractEntityInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AbstractEntity) Initializer

        #region Properties

        private const string PropertyEntityName = "EntityName";

        #endregion

        #region Methods

        private const string MethodSearch = "Search";
        private const string MethodUpdate = "Update";
        private const string MethodGetWatchListByUserId = "GetWatchListByUserId";
        private const string MethodWatch = "Watch";

        #endregion

        #region Fields

        private const string FieldentityName = "entityName";

        #endregion

        #endregion

        #region General Initializer : Class (AbstractEntity) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AbstractEntity_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AbstractEntity) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AbstractEntity_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AbstractEntity) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AbstractEntity_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AbstractEntity)

        #region General Initializer : Class (AbstractEntity) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSearch, 0)]
        [TestCase(MethodUpdate, 0)]
        [TestCase(MethodGetWatchListByUserId, 0)]
        [TestCase(MethodWatch, 0)]
        public void AUT_AbstractEntity_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AbstractEntity) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyEntityName)]
        [Category("AUT Property")]
        public void AUT_AbstractEntity_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (AbstractEntity) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldentityName)]
        [Category("AUT Fields")]
        public void AUT_AbstractEntity_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AbstractEntity) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AbstractEntity_Is_Instance_Present_Test()
        {
            // Assert
            _abstractEntityInstanceType.ShouldNotBeNull();
            _abstractEntityInstance.ShouldNotBeNull();
            _abstractEntityInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AbstractEntity) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AbstractEntity" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AbstractEntity_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _abstractEntityInstance.ShouldBeAssignableTo<AbstractEntity>();
            _abstractEntityInstanceFixture.ShouldBeAssignableTo<AbstractEntity>();
            CurrentInstance.ShouldBeAssignableTo<AbstractEntity>();
        }

        #endregion

        #region General Getters/Setters : Class (AbstractEntity) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AbstractEntity_Class_All_Properties_Getter_Settter_Test()
        {

        }

        #endregion

        #region General Getters/Setters : Class (AbstractEntity) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyEntityName)]
        public void AUT_AbstractEntity_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (AbstractEntity) => Property (EntityName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AbstractEntity_EntityName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEntityName);
            Action currentAction = () => propertyInfo.SetValue(_abstractEntityInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (AbstractEntity) => Property (EntityName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AbstractEntity_Public_Class_EntityName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityName);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion
    }
}