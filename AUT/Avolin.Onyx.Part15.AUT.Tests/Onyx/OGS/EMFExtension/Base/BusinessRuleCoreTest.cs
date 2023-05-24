using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OGS.EMFExtension.Base;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OGS.EMFExtension.Base
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OGS.EMFExtension.Base.BusinessRuleCore" />)
    ///     and namespace <see cref="Onyx.OGS.EMFExtension.Base"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BusinessRuleCoreTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="BusinessRuleCore" />)
        /// </summary>
        public BusinessRuleCoreTest() : base(typeof(BusinessRuleCore))
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

        #region General Initializer : Class (BusinessRuleCore) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _businessRuleCoreInstanceType;
        private BusinessRuleCore _businessRuleCoreInstance;
        private BusinessRuleCore _businessRuleCoreInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="BusinessRuleCore" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _businessRuleCoreInstanceType = typeof(BusinessRuleCore);
            _businessRuleCoreInstanceFixture = this.Create<BusinessRuleCore>(false);
            _businessRuleCoreInstance = _businessRuleCoreInstanceFixture ?? this.Create<BusinessRuleCore>(true);
            CurrentInstance = _businessRuleCoreInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (BusinessRuleCore) Initializer

        #region Methods

        private const string MethodExecuteLBO = "ExecuteLBO";

        #endregion

        #endregion

        #region General Initializer : Class (BusinessRuleCore) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="BusinessRuleCore" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BusinessRuleCore_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (BusinessRuleCore)

        #region General Initializer : Class (BusinessRuleCore) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="BusinessRuleCore" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecuteLBO, 0)]
        public void AUT_BusinessRuleCore_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (BusinessRuleCore) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="BusinessRuleCore" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleCore_Is_Instance_Present_Test()
        {
            // Assert
            _businessRuleCoreInstanceType.ShouldNotBeNull();
            _businessRuleCoreInstance.ShouldNotBeNull();
            _businessRuleCoreInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (BusinessRuleCore) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="BusinessRuleCore" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleCore_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _businessRuleCoreInstance.ShouldBeAssignableTo<BusinessRuleCore>();
            _businessRuleCoreInstanceFixture.ShouldBeAssignableTo<BusinessRuleCore>();
            CurrentInstance.ShouldBeAssignableTo<BusinessRuleCore>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (BusinessRuleCore) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRuleCore_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            BusinessRuleCore instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _businessRuleCoreInstance.ExecuteLBO(parameterCollection, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _businessRuleCoreInstance.ExecuteLBO(parameterCollection, actionElement);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfExecuteLBO = { parameterCollection, actionElement };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, methodExecuteLBOParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_businessRuleCoreInstanceFixture, parametersOfExecuteLBO);
            var result2 = this.GetResultOfMethod<XElement>(MethodExecuteLBO, parametersOfExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteLBO.ShouldNotBeNull();
            parametersOfExecuteLBO.Length.ShouldBe(2);
            methodExecuteLBOParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfExecuteLBO = { parameterCollection, actionElement };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodExecuteLBO, parametersOfExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            parametersOfExecuteLBO.ShouldNotBeNull();
            parametersOfExecuteLBO.Length.ShouldBe(2);
            methodExecuteLBOParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteLBOParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteLBOParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRuleCore_ExecuteLBO_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}