using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File.FileInfoUpdateDate" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FileInfoUpdateDateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FileInfoUpdateDate" />)
        /// </summary>
        public FileInfoUpdateDateTest() : base(typeof(FileInfoUpdateDate))
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

        #region General Initializer : Class (FileInfoUpdateDate) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _fileInfoUpdateDateInstanceType;
        private FileInfoUpdateDate _fileInfoUpdateDateInstance;
        private FileInfoUpdateDate _fileInfoUpdateDateInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FileInfoUpdateDate" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fileInfoUpdateDateInstanceType = typeof(FileInfoUpdateDate);
            _fileInfoUpdateDateInstanceFixture = this.Create<FileInfoUpdateDate>(false);
            _fileInfoUpdateDateInstance = _fileInfoUpdateDateInstanceFixture ?? this.Create<FileInfoUpdateDate>(true);
            CurrentInstance = _fileInfoUpdateDateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FileInfoUpdateDate) Initializer

        #region Methods

        private const string MethodEvaluateDateTime = "EvaluateDateTime";

        #endregion

        #endregion

        #region General Initializer : Class (FileInfoUpdateDate) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FileInfoUpdateDate" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FileInfoUpdateDate_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FileInfoUpdateDate)

        #region General Initializer : Class (FileInfoUpdateDate) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FileInfoUpdateDate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateDateTime, 0)]
        public void AUT_FileInfoUpdateDate_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FileInfoUpdateDate) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FileInfoUpdateDate" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FileInfoUpdateDate_Is_Instance_Present_Test()
        {
            // Assert
            _fileInfoUpdateDateInstanceType.ShouldNotBeNull();
            _fileInfoUpdateDateInstance.ShouldNotBeNull();
            _fileInfoUpdateDateInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FileInfoUpdateDate) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FileInfoUpdateDate" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FileInfoUpdateDate_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _fileInfoUpdateDateInstance.ShouldBeAssignableTo<FileInfoUpdateDate>();
            _fileInfoUpdateDateInstanceFixture.ShouldBeAssignableTo<FileInfoUpdateDate>();
            CurrentInstance.ShouldBeAssignableTo<FileInfoUpdateDate>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FileInfoUpdateDate) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FileInfoUpdateDate_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FileInfoUpdateDate instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _fileInfoUpdateDateInstance.EvaluateDateTime(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = _fileInfoUpdateDateInstance.EvaluateDateTime(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DateTime>(_fileInfoUpdateDateInstanceFixture, out exception1, parametersOfEvaluateDateTime);
            var result2 = this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_fileInfoUpdateDateInstanceFixture, parametersOfEvaluateDateTime);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileInfoUpdateDate_EvaluateDateTime_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 0);
            const int parametersCount = 1;

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