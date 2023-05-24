using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.BusinessLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.XmlTransformerBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class XmlTransformerBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlTransformerBusinessLayer" />)
        /// </summary>
        public XmlTransformerBusinessLayerTest() : base(typeof(XmlTransformerBusinessLayer))
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

        #region General Initializer : Class (XmlTransformerBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlTransformerBusinessLayerInstanceType;
        private XmlTransformerBusinessLayer _xmlTransformerBusinessLayerInstance;
        private XmlTransformerBusinessLayer _xmlTransformerBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="XmlTransformerBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlTransformerBusinessLayerInstanceType = typeof(XmlTransformerBusinessLayer);
            _xmlTransformerBusinessLayerInstanceFixture = this.Create<XmlTransformerBusinessLayer>(false);
            _xmlTransformerBusinessLayerInstance = _xmlTransformerBusinessLayerInstanceFixture ?? this.Create<XmlTransformerBusinessLayer>(true);
            CurrentInstance = _xmlTransformerBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlTransformerBusinessLayer) Initializer

        #region Methods

        private const string MethodTransformXml = "TransformXml";

        #endregion

        #endregion

        #region General Initializer : Class (XmlTransformerBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlTransformerBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlTransformerBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="XmlTransformerBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlTransformerBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlTransformerBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlTransformerBusinessLayer)

        #region General Initializer : Class (XmlTransformerBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlTransformerBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTransformXml, 0)]
        public void AUT_XmlTransformerBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (XmlTransformerBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="XmlTransformerBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlTransformerBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _xmlTransformerBusinessLayerInstanceType.ShouldNotBeNull();
            _xmlTransformerBusinessLayerInstance.ShouldNotBeNull();
            _xmlTransformerBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (XmlTransformerBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="XmlTransformerBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlTransformerBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _xmlTransformerBusinessLayerInstance.ShouldBeAssignableTo<XmlTransformerBusinessLayer>();
            _xmlTransformerBusinessLayerInstanceFixture.ShouldBeAssignableTo<XmlTransformerBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<XmlTransformerBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (XmlTransformerBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlTransformerBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            XmlTransformerBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (TransformXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xslName = this.CreateType<string>();
            var xmlData = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _xmlTransformerBusinessLayerInstance.TransformXml(xslName, xmlData, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xslName = this.CreateType<string>();
            var xmlData = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlTransformerBusinessLayerInstance.TransformXml(xslName, xmlData, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xslName = this.CreateType<string>();
            var xmlData = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodTransformXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfTransformXml = { xslName, xmlData, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTransformXml, methodTransformXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlTransformerBusinessLayerInstanceFixture, parametersOfTransformXml);
            var result2 = this.GetResultOfMethod<string>(MethodTransformXml, parametersOfTransformXml, methodTransformXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfTransformXml.ShouldNotBeNull();
            parametersOfTransformXml.Length.ShouldBe(3);
            methodTransformXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var xslName = this.CreateType<string>();
            var xmlData = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodTransformXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfTransformXml = { xslName, xmlData, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodTransformXml, parametersOfTransformXml, methodTransformXmlParametersTypes);

            // Assert
            parametersOfTransformXml.ShouldNotBeNull();
            parametersOfTransformXml.Length.ShouldBe(3);
            methodTransformXmlParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var methodTransformXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTransformXml, methodTransformXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodTransformXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var methodTransformXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTransformXml, methodTransformXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTransformXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TransformXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (TransformXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlTransformerBusinessLayer_TransformXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformXml);
            var currentMethodInfo = this.GetMethodInfo(MethodTransformXml, 0);
            const int parametersCount = 3;

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