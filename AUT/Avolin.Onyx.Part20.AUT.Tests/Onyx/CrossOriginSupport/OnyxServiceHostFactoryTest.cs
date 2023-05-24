using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.CrossOriginSupport;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.CrossOriginSupport
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CrossOriginSupport.OnyxServiceHostFactory" />)
    ///     and namespace <see cref="Onyx.CrossOriginSupport"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxServiceHostFactoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxServiceHostFactory" />)
        /// </summary>
        public OnyxServiceHostFactoryTest() : base(typeof(OnyxServiceHostFactory))
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

        #region General Initializer : Class (OnyxServiceHostFactory) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxServiceHostFactoryInstanceType;
        private OnyxServiceHostFactory _onyxServiceHostFactoryInstance;
        private OnyxServiceHostFactory _onyxServiceHostFactoryInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxServiceHostFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxServiceHostFactoryInstanceType = typeof(OnyxServiceHostFactory);
            _onyxServiceHostFactoryInstanceFixture = this.Create<OnyxServiceHostFactory>(false);
            _onyxServiceHostFactoryInstance = _onyxServiceHostFactoryInstanceFixture ?? this.Create<OnyxServiceHostFactory>(true);
            CurrentInstance = _onyxServiceHostFactoryInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxServiceHostFactory) Initializer

        #region Methods

        private const string MethodCreateServiceHost = "CreateServiceHost";
        private const string MethodOnHostOpening = "OnHostOpening";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxServiceHostFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxServiceHostFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxServiceHostFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region General Initializer : Class (OnyxServiceHostFactory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxServiceHostFactory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxServiceHostFactory_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxServiceHostFactory)

        #region General Initializer : Class (OnyxServiceHostFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxServiceHostFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateServiceHost, 0)]
        [TestCase(MethodOnHostOpening, 0)]
        public void AUT_OnyxServiceHostFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxServiceHostFactory) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxServiceHostFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxServiceHostFactory_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxServiceHostFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxServiceHostFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxServiceHostFactory_Is_Instance_Present_Test()
        {
            // Assert
            _onyxServiceHostFactoryInstanceType.ShouldNotBeNull();
            _onyxServiceHostFactoryInstance.ShouldNotBeNull();
            _onyxServiceHostFactoryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxServiceHostFactory) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxServiceHostFactory" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxServiceHostFactory_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxServiceHostFactoryInstance.ShouldBeAssignableTo<OnyxServiceHostFactory>();
            _onyxServiceHostFactoryInstanceFixture.ShouldBeAssignableTo<OnyxServiceHostFactory>();
            CurrentInstance.ShouldBeAssignableTo<OnyxServiceHostFactory>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxServiceHostFactory) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxServiceHostFactory_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxServiceHostFactory instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateServiceHost) (Return Type : ServiceHost) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_CreateServiceHost_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateServiceHost);
            var serviceType = this.CreateType<Type>();
            var baseAddresses = this.CreateType<Uri[]>();
            var methodCreateServiceHostParametersTypes = new Type[] { typeof(Type), typeof(Uri[]) };
            object[] parametersOfCreateServiceHost = { serviceType, baseAddresses };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateServiceHost, methodCreateServiceHostParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ServiceHost>(_onyxServiceHostFactoryInstanceFixture, parametersOfCreateServiceHost);
            var result2 = this.GetResultOfMethod<ServiceHost>(MethodCreateServiceHost, parametersOfCreateServiceHost, methodCreateServiceHostParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateServiceHost.ShouldNotBeNull();
            parametersOfCreateServiceHost.Length.ShouldBe(2);
            methodCreateServiceHostParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateServiceHost) (Return Type : ServiceHost) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_CreateServiceHost_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateServiceHost);
            var serviceType = this.CreateType<Type>();
            var baseAddresses = this.CreateType<Uri[]>();
            var methodCreateServiceHostParametersTypes = new Type[] { typeof(Type), typeof(Uri[]) };
            object[] parametersOfCreateServiceHost = { serviceType, baseAddresses };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ServiceHost>(MethodCreateServiceHost, parametersOfCreateServiceHost, methodCreateServiceHostParametersTypes);

            // Assert
            parametersOfCreateServiceHost.ShouldNotBeNull();
            parametersOfCreateServiceHost.Length.ShouldBe(2);
            methodCreateServiceHostParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateServiceHost) (Return Type : ServiceHost) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_CreateServiceHost_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateServiceHost);
            var methodCreateServiceHostParametersTypes = new Type[] { typeof(Type), typeof(Uri[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateServiceHost, methodCreateServiceHostParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateServiceHostParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateServiceHost) (Return Type : ServiceHost) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_CreateServiceHost_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateServiceHost);
            var methodCreateServiceHostParametersTypes = new Type[] { typeof(Type), typeof(Uri[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateServiceHost, methodCreateServiceHostParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateServiceHostParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (CreateServiceHost) (Return Type : ServiceHost) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_CreateServiceHost_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateServiceHost);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateServiceHost, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateServiceHost) (Return Type : ServiceHost) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_CreateServiceHost_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateServiceHost);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateServiceHost, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnHostOpening) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxServiceHostFactory_OnHostOpening_Method_Call_Internally(Type[] types)
        {
            var methodOnHostOpeningParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnHostOpening, methodOnHostOpeningParametersTypes);
        }

        #endregion

        #region Method Call : (OnHostOpening) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_OnHostOpening_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHostOpening);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodOnHostOpeningParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfOnHostOpening = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnHostOpening, methodOnHostOpeningParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxServiceHostFactoryInstanceFixture, parametersOfOnHostOpening);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnHostOpening.ShouldNotBeNull();
            parametersOfOnHostOpening.Length.ShouldBe(2);
            methodOnHostOpeningParametersTypes.Length.ShouldBe(2);
            methodOnHostOpeningParametersTypes.Length.ShouldBe(parametersOfOnHostOpening.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion
        
        #region Method Call : (OnHostOpening) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_OnHostOpening_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHostOpening);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodOnHostOpeningParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfOnHostOpening = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnHostOpening, parametersOfOnHostOpening, methodOnHostOpeningParametersTypes);

            // Assert
            parametersOfOnHostOpening.ShouldNotBeNull();
            parametersOfOnHostOpening.Length.ShouldBe(2);
            methodOnHostOpeningParametersTypes.Length.ShouldBe(2);
            methodOnHostOpeningParametersTypes.Length.ShouldBe(parametersOfOnHostOpening.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnHostOpening) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_OnHostOpening_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHostOpening);
            var currentMethodInfo = this.GetMethodInfo(MethodOnHostOpening, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnHostOpening) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_OnHostOpening_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHostOpening);
            var methodOnHostOpeningParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnHostOpening, methodOnHostOpeningParametersTypes);

            // Assert
            methodOnHostOpeningParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnHostOpening) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxServiceHostFactory_OnHostOpening_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHostOpening);
            var currentMethodInfo = this.GetMethodInfo(MethodOnHostOpening, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}