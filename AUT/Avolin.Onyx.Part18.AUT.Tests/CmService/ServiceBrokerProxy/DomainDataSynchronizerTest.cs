using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using CmService.ServiceBrokerProxy;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.CmService.ServiceBrokerProxy
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.ServiceBrokerProxy.DomainDataSynchronizer" />)
    ///     and namespace <see cref="CmService.ServiceBrokerProxy"/> class using generator(v:0.2.5)'s
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

        #region Fields

        private const string FieldNODE_REMOTING = "NODE_REMOTING";
        private const string FieldNODE_EXTRA_DATA = "NODE_EXTRA_DATA";
        private const string FieldNODE_KEY_FILE = "NODE_KEY_FILE";
        private const string FieldEDM_PERSISTENCE_DB = "EDM_PERSISTENCE_DB";
        private const string FieldEDM_OEDB = "EDM_OEDB";
        private const string FieldNODE_RESULT = "NODE_RESULT";
        private const string FieldNODE_STATUS = "NODE_STATUS";
        private const string FieldNODE_ERROR = "NODE_ERROR";
        private const string FieldSTATUS_SUCCESS = "STATUS_SUCCESS";

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

        #region General Initializer : Class (DomainDataSynchronizer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DomainDataSynchronizer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DomainDataSynchronizer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

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

        #region General Initializer : Class (DomainDataSynchronizer) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DomainDataSynchronizer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNODE_REMOTING)]
        [TestCase(FieldNODE_EXTRA_DATA)]
        [TestCase(FieldNODE_KEY_FILE)]
        [TestCase(FieldEDM_PERSISTENCE_DB)]
        [TestCase(FieldEDM_OEDB)]
        [TestCase(FieldNODE_RESULT)]
        [TestCase(FieldNODE_STATUS)]
        [TestCase(FieldNODE_ERROR)]
        [TestCase(FieldSTATUS_SUCCESS)]
        [Category("AUT Fields")]
        public void AUT_DomainDataSynchronizer_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);

            // Act
            Action executeAction = () => _domainDataSynchronizerInstance.SynchronizeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataSynchronizerInstance.SynchronizeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            Type [] methodSynchronizeDomainDataParametersTypes = null;
            object[] parametersOfSynchronizeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataSynchronizerInstanceFixture, parametersOfSynchronizeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodSynchronizeDomainData, parametersOfSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSynchronizeDomainData.ShouldBeNull();
            methodSynchronizeDomainDataParametersTypes.ShouldBeNull();
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
            Type [] methodSynchronizeDomainDataParametersTypes = null;
            object[] parametersOfSynchronizeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSynchronizeDomainData, parametersOfSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            parametersOfSynchronizeDomainData.ShouldBeNull();
            methodSynchronizeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            Type [] methodSynchronizeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSynchronizeDomainDataParametersTypes.ShouldBeNull();
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
            Type [] methodSynchronizeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSynchronizeDomainData, methodSynchronizeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSynchronizeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SynchronizeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainDataSynchronizer_SynchronizeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSynchronizeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodSynchronizeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}