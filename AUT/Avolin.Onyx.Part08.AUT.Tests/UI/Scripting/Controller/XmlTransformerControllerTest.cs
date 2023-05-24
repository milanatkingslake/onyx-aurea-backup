using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Controller;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.XmlTransformerController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class XmlTransformerControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlTransformerController" />)
        /// </summary>
        public XmlTransformerControllerTest() : base(typeof(XmlTransformerController))
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

        #region General Initializer : Class (XmlTransformerController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlTransformerControllerInstanceType;
        private XmlTransformerController _xmlTransformerControllerInstance;
        private XmlTransformerController _xmlTransformerControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="XmlTransformerController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlTransformerControllerInstanceType = typeof(XmlTransformerController);
            _xmlTransformerControllerInstanceFixture = this.Create<XmlTransformerController>(false);
            _xmlTransformerControllerInstance = _xmlTransformerControllerInstanceFixture ?? this.Create<XmlTransformerController>(true);
            CurrentInstance = _xmlTransformerControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlTransformerController) Initializer

        #region Methods

        private const string MethodTransformXml = "TransformXml";

        #endregion

        #endregion

        #region General Initializer : Class (XmlTransformerController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlTransformerController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlTransformerController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="XmlTransformerController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlTransformerController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlTransformerController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlTransformerController)

        #region General Initializer : Class (XmlTransformerController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlTransformerController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTransformXml, 0)]
        public void AUT_XmlTransformerController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (XmlTransformerController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="XmlTransformerController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlTransformerController_Is_Instance_Present_Test()
        {
            // Assert
            _xmlTransformerControllerInstanceType.ShouldNotBeNull();
            _xmlTransformerControllerInstance.ShouldNotBeNull();
            _xmlTransformerControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (XmlTransformerController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="XmlTransformerController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlTransformerController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _xmlTransformerControllerInstance.ShouldBeAssignableTo<XmlTransformerController>();
            _xmlTransformerControllerInstanceFixture.ShouldBeAssignableTo<XmlTransformerController>();
            CurrentInstance.ShouldBeAssignableTo<XmlTransformerController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (XmlTransformerController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlTransformerController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            XmlTransformerController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xmlTransformerData = this.CreateType<XmlTransformerModel>();

            // Act
            Action executeAction = () => _xmlTransformerControllerInstance.TransformXml(xmlTransformerData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xmlTransformerData = this.CreateType<XmlTransformerModel>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _xmlTransformerControllerInstance.TransformXml(xmlTransformerData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xmlTransformerData = this.CreateType<XmlTransformerModel>();
            var methodTransformXmlParametersTypes = new Type[] { typeof(XmlTransformerModel) };
            object[] parametersOfTransformXml = { xmlTransformerData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTransformXml, methodTransformXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_xmlTransformerControllerInstanceFixture, parametersOfTransformXml);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodTransformXml, parametersOfTransformXml, methodTransformXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfTransformXml.ShouldNotBeNull();
            parametersOfTransformXml.Length.ShouldBe(1);
            methodTransformXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xmlTransformerData = this.CreateType<XmlTransformerModel>();
            var methodTransformXmlParametersTypes = new Type[] { typeof(XmlTransformerModel) };
            object[] parametersOfTransformXml = { xmlTransformerData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodTransformXml, parametersOfTransformXml, methodTransformXmlParametersTypes);

            // Assert
            parametersOfTransformXml.ShouldNotBeNull();
            parametersOfTransformXml.Length.ShouldBe(1);
            methodTransformXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var methodTransformXmlParametersTypes = new Type[] { typeof(XmlTransformerModel) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTransformXml, methodTransformXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodTransformXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var methodTransformXmlParametersTypes = new Type[] { typeof(XmlTransformerModel) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTransformXml, methodTransformXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTransformXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var currentMethodInfo = this.GetMethodInfo(MethodTransformXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerController_TransformXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var currentMethodInfo = this.GetMethodInfo(MethodTransformXml, 0);
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