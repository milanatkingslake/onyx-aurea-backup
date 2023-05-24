using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Interfaces;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.OperatorBase<IGenericArgumentSample>" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OperatorBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OperatorBase<IGenericArgumentSample>" />)
        /// </summary>
        public OperatorBaseTest() : base(typeof(OperatorBase<IGenericArgumentSample>))
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

        #region General Initializer : Class (OperatorBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _operatorBaseInstanceType;
        private OperatorBase<IGenericArgumentSample> _operatorBaseInstance;
        private OperatorBase<IGenericArgumentSample> _operatorBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OperatorBase<IGenericArgumentSample>" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _operatorBaseInstanceType = typeof(OperatorBase<IGenericArgumentSample>);
            _operatorBaseInstanceFixture = this.Create<OperatorBase<IGenericArgumentSample>>(false);
            _operatorBaseInstance = _operatorBaseInstanceFixture ?? this.Create<OperatorBase<IGenericArgumentSample>>(true);
            CurrentInstance = _operatorBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OperatorBase) Initializer

        #region Properties

        private const string PropertyleftValue = "leftValue";
        private const string PropertyrightValue = "rightValue";

        #endregion

        #region Methods

        private const string MethodGetValues = "GetValues";

        #endregion

        #region Fields

        private const string Fieldm_leftValue = "m_leftValue";
        private const string Fieldm_rightValue = "m_rightValue";

        #endregion

        #endregion

        #region General Initializer : Class (OperatorBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OperatorBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OperatorBase) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OperatorBase_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OperatorBase) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OperatorBase_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OperatorBase)

        #region General Initializer : Class (OperatorBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetValues, 0)]
        public void AUT_OperatorBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OperatorBase) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyleftValue)]
        [TestCase(PropertyrightValue)]
        [Category("AUT Property")]
        public void AUT_OperatorBase_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OperatorBase) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_leftValue)]
        [TestCase(Fieldm_rightValue)]
        [Category("AUT Fields")]
        public void AUT_OperatorBase_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OperatorBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OperatorBase_Is_Instance_Present_Test()
        {
            // Assert
            _operatorBaseInstanceType.ShouldNotBeNull();
            _operatorBaseInstance.ShouldNotBeNull();
            _operatorBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OperatorBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OperatorBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OperatorBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _operatorBaseInstance.ShouldBeAssignableTo<OperatorBase<IGenericArgumentSample>>();
            _operatorBaseInstanceFixture.ShouldBeAssignableTo<OperatorBase<IGenericArgumentSample>>();
            CurrentInstance.ShouldBeAssignableTo<OperatorBase<IGenericArgumentSample>>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OperatorBase) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyleftValue)]
        [TestCase(PropertyrightValue)]
        public void AUT_OperatorBase_Property_Exist_By_Name_Verify_Test(string name)
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

        #endregion

        #endregion
    }
}