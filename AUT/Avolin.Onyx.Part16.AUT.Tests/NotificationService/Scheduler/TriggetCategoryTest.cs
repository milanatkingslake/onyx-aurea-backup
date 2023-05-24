using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Scheduler;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Scheduler
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Scheduler.TriggetCategory" />)
    ///     and namespace <see cref="NotificationService.Scheduler"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TriggetCategoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="TriggetCategoryNonPublicTypeName" />) using
        ///     Using a public type <see cref="Administration" /> to
        ///     create a non-public type.
        /// </summary>
        public TriggetCategoryTest() : base(publicType: typeof(global::NotificationService.Scheduler.Administration), classNameWithNamespace: TriggetCategoryNonPublicTypeName)
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

        private Type _triggetCategoryInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string TriggetCategoryNonPublicTypeName = "NotificationService.Scheduler.TriggetCategory";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _triggetCategoryInstance;
        private object _triggetCategoryInstanceFixture;

        #region General Initializer : Class (TriggetCategory) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="TriggetCategory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _triggetCategoryInstanceFixture = this.CreateNonPublicType(TriggetCategoryNonPublicTypeName);
            _triggetCategoryInstance = _triggetCategoryInstanceFixture;
            CurrentInstance = _triggetCategoryInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TriggetCategory) Initializer

        #region Properties

        private const string PropertyIs24x7Category = "Is24x7Category";

        #endregion

        #region Methods

        private const string MethodAdd = "Add";
        private const string MethodGetNextTrigger = "GetNextTrigger";
        private const string MethodClean = "Clean";
        private const string MethodBeginExecute = "BeginExecute";
        private const string MethodGetTriggerTimeStatus = "GetTriggerTimeStatus";
        private const string MethodExecute = "Execute";
        private const string MethodTriggerDispatchAgent = "TriggerDispatchAgent";

        #endregion

        #region Fields

        private const string FieldTriggers = "Triggers";
        private const string FieldiLog = "iLog";
        private const string FieldcurrentTrigger = "currentTrigger";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (TriggetCategory)

        #region General Initializer : Class (TriggetCategory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TriggetCategory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAdd, 0)]
        [TestCase(MethodGetNextTrigger, 0)]
        [TestCase(MethodClean, 0)]
        [TestCase(MethodBeginExecute, 0)]
        [TestCase(MethodGetTriggerTimeStatus, 0)]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodTriggerDispatchAgent, 0)]
        [Category("AUT Explore")]
        public void AUT_TriggetCategory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TriggetCategory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TriggetCategory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TriggetCategory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TriggetCategory) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TriggetCategory" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIs24x7Category)]
        [Category("AUT Property")]
        public void AUT_TriggetCategory_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TriggetCategory) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TriggetCategory" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TriggetCategory_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TriggetCategory) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TriggetCategory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldTriggers)]
        [TestCase(FieldiLog)]
        [TestCase(FieldcurrentTrigger)]
        [Category("AUT Fields")]
        public void AUT_TriggetCategory_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TriggetCategory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TriggetCategory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TriggetCategory_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TriggetCategory) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIs24x7Category)]
        public void AUT_TriggetCategory_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TriggetCategory) => Property (Is24x7Category) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TriggetCategory_Public_Class_Is24x7Category_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIs24x7Category);
            var propertyInfo = this.GetPropertyInfo(PropertyIs24x7Category);

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