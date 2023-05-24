using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using ServiceBroker;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.ServiceBroker
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ServiceBroker.DomainDataSynchronizer" />)
    ///     and namespace <see cref="ServiceBroker"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DomainDataSynchronizerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DomainDataSynchronizer" />)
        /// </summary>
        public DomainDataSynchronizerTest() : base(typeof(DomainDataSynchronizer))
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

        #region General Initializer : Class (DomainDataSynchronizer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _domainDataSynchronizerInstanceType;
        private DomainDataSynchronizer _domainDataSynchronizerInstance;
        private DomainDataSynchronizer _domainDataSynchronizerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DomainDataSynchronizer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _domainDataSynchronizerInstanceType = typeof(DomainDataSynchronizer);
            _domainDataSynchronizerInstanceFixture = this.Create<DomainDataSynchronizer>(false);
            _domainDataSynchronizerInstance = _domainDataSynchronizerInstanceFixture ?? this.Create<DomainDataSynchronizer>(true);
            CurrentInstance = _domainDataSynchronizerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DomainDataSynchronizer) Initializer

        #region Methods

        private const string MethodSynchronizeDomainData = "SynchronizeDomainData";

        #endregion

        #endregion

        #region General Initializer : Class (DomainDataSynchronizer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DomainDataSynchronizer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DomainDataSynchronizer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DomainDataSynchronizer)

        #region General Initializer : Class (DomainDataSynchronizer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DomainDataSynchronizer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSynchronizeDomainData, 0)]
        public void AUT_DomainDataSynchronizer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DomainDataSynchronizer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DomainDataSynchronizer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DomainDataSynchronizer_Is_Instance_Present_Test()
        {
            // Assert
            _domainDataSynchronizerInstanceType.ShouldNotBeNull();
            _domainDataSynchronizerInstance.ShouldNotBeNull();
            _domainDataSynchronizerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DomainDataSynchronizer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DomainDataSynchronizer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DomainDataSynchronizer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _domainDataSynchronizerInstance.ShouldBeAssignableTo<DomainDataSynchronizer>();
            _domainDataSynchronizerInstanceFixture.ShouldBeAssignableTo<DomainDataSynchronizer>();
            CurrentInstance.ShouldBeAssignableTo<DomainDataSynchronizer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DomainDataSynchronizer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DomainDataSynchronizer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DomainDataSynchronizer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var serverName = this.CreateType<string>();
            var oedbName = this.CreateType<string>();
            var pdbName = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var keyFileName = this.CreateType<string>();

            // Act
            Action executeAction = () => _domainDataSynchronizerInstance.SynchronizeDomainData(serverName, oedbName, pdbName, userId, password, keyFileName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var serverName = this.CreateType<string>();
            var oedbName = this.CreateType<string>();
            var pdbName = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var keyFileName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataSynchronizerInstance.SynchronizeDomainData(serverName, oedbName, pdbName, userId, password, keyFileName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var serverName = this.CreateType<string>();
            var oedbName = this.CreateType<string>();
            var pdbName = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var keyFileName = this.CreateType<string>();
            var methodSynchronizeDomainDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSynchronizeDomainData = { serverName, oedbName, pdbName, userId, password, keyFileName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataSynchronizerInstanceFixture, out exception1, parametersOfSynchronizeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodSynchronizeDomainData, parametersOfSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSynchronizeDomainData.ShouldNotBeNull();
            parametersOfSynchronizeDomainData.Length.ShouldBe(6);
            methodSynchronizeDomainDataParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var serverName = this.CreateType<string>();
            var oedbName = this.CreateType<string>();
            var pdbName = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var keyFileName = this.CreateType<string>();
            var methodSynchronizeDomainDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSynchronizeDomainData = { serverName, oedbName, pdbName, userId, password, keyFileName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_domainDataSynchronizerInstanceFixture, parametersOfSynchronizeDomainData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSynchronizeDomainData.ShouldNotBeNull();
            parametersOfSynchronizeDomainData.Length.ShouldBe(6);
            methodSynchronizeDomainDataParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var serverName = this.CreateType<string>();
            var oedbName = this.CreateType<string>();
            var pdbName = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var keyFileName = this.CreateType<string>();
            var methodSynchronizeDomainDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSynchronizeDomainData = { serverName, oedbName, pdbName, userId, password, keyFileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSynchronizeDomainData, parametersOfSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            parametersOfSynchronizeDomainData.ShouldNotBeNull();
            parametersOfSynchronizeDomainData.Length.ShouldBe(6);
            methodSynchronizeDomainDataParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var methodSynchronizeDomainDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSynchronizeDomainDataParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var methodSynchronizeDomainDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSynchronizeDomainDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodSynchronizeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodSynchronizeDomainData, 0);
            const int parametersCount = 6;

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