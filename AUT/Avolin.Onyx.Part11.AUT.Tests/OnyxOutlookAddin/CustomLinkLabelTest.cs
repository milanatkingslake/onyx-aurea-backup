using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CustomLinkLabel" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomLinkLabelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomLinkLabel" />)
        /// </summary>
        public CustomLinkLabelTest() : base(typeof(CustomLinkLabel))
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

        #region General Initializer : Class (CustomLinkLabel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customLinkLabelInstanceType;
        private CustomLinkLabel _customLinkLabelInstance;
        private CustomLinkLabel _customLinkLabelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CustomLinkLabel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customLinkLabelInstanceType = typeof(CustomLinkLabel);
            _customLinkLabelInstanceFixture = this.Create<CustomLinkLabel>(false);
            _customLinkLabelInstance = _customLinkLabelInstanceFixture ?? this.Create<CustomLinkLabel>(true);
            CurrentInstance = _customLinkLabelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomLinkLabel) Initializer

        #region Methods

        private const string MethodemailLinkClickedComposeEmail = "emailLinkClickedComposeEmail";
        private const string MethodurlLinkClickedOpenBrowser = "urlLinkClickedOpenBrowser";
        private const string MethodoepLauncherLinkClicked = "oepLauncherLinkClicked";
        private const string MethodCreate = "Create";

        #endregion

        #region Fields

        private const string FieldhyperLinkEventHandlers = "hyperLinkEventHandlers";

        #endregion

        #endregion

        #region General Initializer : Class (CustomLinkLabel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomLinkLabel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomLinkLabel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomLinkLabel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomLinkLabel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomLinkLabel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomLinkLabel)

        #region General Initializer : Class (CustomLinkLabel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomLinkLabel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodemailLinkClickedComposeEmail, 0)]
        [TestCase(MethodurlLinkClickedOpenBrowser, 0)]
        [TestCase(MethodoepLauncherLinkClicked, 0)]
        [TestCase(MethodCreate, 0)]
        public void AUT_CustomLinkLabel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CustomLinkLabel) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomLinkLabel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldhyperLinkEventHandlers)]
        [Category("AUT Fields")]
        public void AUT_CustomLinkLabel_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CustomLinkLabel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomLinkLabel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomLinkLabel_Is_Instance_Present_Test()
        {
            // Assert
            _customLinkLabelInstanceType.ShouldNotBeNull();
            _customLinkLabelInstance.ShouldNotBeNull();
            _customLinkLabelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CustomLinkLabel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CustomLinkLabel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomLinkLabel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _customLinkLabelInstance.ShouldBeAssignableTo<CustomLinkLabel>();
            _customLinkLabelInstanceFixture.ShouldBeAssignableTo<CustomLinkLabel>();
            CurrentInstance.ShouldBeAssignableTo<CustomLinkLabel>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (emailLinkClickedComposeEmail) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_emailLinkClickedComposeEmail_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailLinkClickedComposeEmail);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodemailLinkClickedComposeEmailParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfemailLinkClickedComposeEmail = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodemailLinkClickedComposeEmail, methodemailLinkClickedComposeEmailParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customLinkLabelInstanceFixture, parametersOfemailLinkClickedComposeEmail);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfemailLinkClickedComposeEmail.ShouldNotBeNull();
            parametersOfemailLinkClickedComposeEmail.Length.ShouldBe(2);
            methodemailLinkClickedComposeEmailParametersTypes.Length.ShouldBe(2);
            methodemailLinkClickedComposeEmailParametersTypes.Length.ShouldBe(parametersOfemailLinkClickedComposeEmail.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (emailLinkClickedComposeEmail) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_emailLinkClickedComposeEmail_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailLinkClickedComposeEmail);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodemailLinkClickedComposeEmailParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfemailLinkClickedComposeEmail = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodemailLinkClickedComposeEmail, parametersOfemailLinkClickedComposeEmail, methodemailLinkClickedComposeEmailParametersTypes);

            // Assert
            parametersOfemailLinkClickedComposeEmail.ShouldNotBeNull();
            parametersOfemailLinkClickedComposeEmail.Length.ShouldBe(2);
            methodemailLinkClickedComposeEmailParametersTypes.Length.ShouldBe(2);
            methodemailLinkClickedComposeEmailParametersTypes.Length.ShouldBe(parametersOfemailLinkClickedComposeEmail.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailLinkClickedComposeEmail) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_emailLinkClickedComposeEmail_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailLinkClickedComposeEmail);
            var currentMethodInfo = this.GetMethodInfo(MethodemailLinkClickedComposeEmail, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (emailLinkClickedComposeEmail) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_emailLinkClickedComposeEmail_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailLinkClickedComposeEmail);
            var methodemailLinkClickedComposeEmailParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodemailLinkClickedComposeEmail, methodemailLinkClickedComposeEmailParametersTypes);

            // Assert
            methodemailLinkClickedComposeEmailParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailLinkClickedComposeEmail) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_emailLinkClickedComposeEmail_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailLinkClickedComposeEmail);
            var currentMethodInfo = this.GetMethodInfo(MethodemailLinkClickedComposeEmail, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (urlLinkClickedOpenBrowser) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomLinkLabel_urlLinkClickedOpenBrowser_Method_Call_Internally(Type[] types)
        {
            var methodurlLinkClickedOpenBrowserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodurlLinkClickedOpenBrowser, methodurlLinkClickedOpenBrowserParametersTypes);
        }

        #endregion

        #region Method Call : (urlLinkClickedOpenBrowser) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_urlLinkClickedOpenBrowser_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodurlLinkClickedOpenBrowser);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodurlLinkClickedOpenBrowserParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfurlLinkClickedOpenBrowser = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodurlLinkClickedOpenBrowser, methodurlLinkClickedOpenBrowserParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customLinkLabelInstanceFixture, parametersOfurlLinkClickedOpenBrowser);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfurlLinkClickedOpenBrowser.ShouldNotBeNull();
            parametersOfurlLinkClickedOpenBrowser.Length.ShouldBe(2);
            methodurlLinkClickedOpenBrowserParametersTypes.Length.ShouldBe(2);
            methodurlLinkClickedOpenBrowserParametersTypes.Length.ShouldBe(parametersOfurlLinkClickedOpenBrowser.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (urlLinkClickedOpenBrowser) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_urlLinkClickedOpenBrowser_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodurlLinkClickedOpenBrowser);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodurlLinkClickedOpenBrowserParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfurlLinkClickedOpenBrowser = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodurlLinkClickedOpenBrowser, parametersOfurlLinkClickedOpenBrowser, methodurlLinkClickedOpenBrowserParametersTypes);

            // Assert
            parametersOfurlLinkClickedOpenBrowser.ShouldNotBeNull();
            parametersOfurlLinkClickedOpenBrowser.Length.ShouldBe(2);
            methodurlLinkClickedOpenBrowserParametersTypes.Length.ShouldBe(2);
            methodurlLinkClickedOpenBrowserParametersTypes.Length.ShouldBe(parametersOfurlLinkClickedOpenBrowser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (urlLinkClickedOpenBrowser) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_urlLinkClickedOpenBrowser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodurlLinkClickedOpenBrowser);
            var currentMethodInfo = this.GetMethodInfo(MethodurlLinkClickedOpenBrowser, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (urlLinkClickedOpenBrowser) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_urlLinkClickedOpenBrowser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodurlLinkClickedOpenBrowser);
            var methodurlLinkClickedOpenBrowserParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodurlLinkClickedOpenBrowser, methodurlLinkClickedOpenBrowserParametersTypes);

            // Assert
            methodurlLinkClickedOpenBrowserParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (urlLinkClickedOpenBrowser) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_urlLinkClickedOpenBrowser_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodurlLinkClickedOpenBrowser);
            var currentMethodInfo = this.GetMethodInfo(MethodurlLinkClickedOpenBrowser, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (oepLauncherLinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomLinkLabel_oepLauncherLinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodoepLauncherLinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodoepLauncherLinkClicked, methodoepLauncherLinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (oepLauncherLinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_oepLauncherLinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoepLauncherLinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodoepLauncherLinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfoepLauncherLinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodoepLauncherLinkClicked, methodoepLauncherLinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customLinkLabelInstanceFixture, parametersOfoepLauncherLinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfoepLauncherLinkClicked.ShouldNotBeNull();
            parametersOfoepLauncherLinkClicked.Length.ShouldBe(2);
            methodoepLauncherLinkClickedParametersTypes.Length.ShouldBe(2);
            methodoepLauncherLinkClickedParametersTypes.Length.ShouldBe(parametersOfoepLauncherLinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (oepLauncherLinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_oepLauncherLinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoepLauncherLinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodoepLauncherLinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfoepLauncherLinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodoepLauncherLinkClicked, parametersOfoepLauncherLinkClicked, methodoepLauncherLinkClickedParametersTypes);

            // Assert
            parametersOfoepLauncherLinkClicked.ShouldNotBeNull();
            parametersOfoepLauncherLinkClicked.Length.ShouldBe(2);
            methodoepLauncherLinkClickedParametersTypes.Length.ShouldBe(2);
            methodoepLauncherLinkClickedParametersTypes.Length.ShouldBe(parametersOfoepLauncherLinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (oepLauncherLinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_oepLauncherLinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoepLauncherLinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodoepLauncherLinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (oepLauncherLinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_oepLauncherLinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoepLauncherLinkClicked);
            var methodoepLauncherLinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodoepLauncherLinkClicked, methodoepLauncherLinkClickedParametersTypes);

            // Assert
            methodoepLauncherLinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (oepLauncherLinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_oepLauncherLinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoepLauncherLinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodoepLauncherLinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomLinkLabel_Create_Method_Call_Internally(Type[] types)
        {
            var methodCreateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var dataType = this.CreateType<string>();
            var text = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var oepLauncherType = this.CreateType<string>();
            var level = this.CreateType<int>();

            // Act
            Action executeAction = () => _customLinkLabelInstance.Create(dataType, text, objectId, oepLauncherType, level);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var dataType = this.CreateType<string>();
            var text = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var oepLauncherType = this.CreateType<string>();
            var level = this.CreateType<int>();
            var returnedValue = default(LinkLabel);

            // Act
            Action executeAction = () => returnedValue = _customLinkLabelInstance.Create(dataType, text, objectId, oepLauncherType, level);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var dataType = this.CreateType<string>();
            var text = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var oepLauncherType = this.CreateType<string>();
            var level = this.CreateType<int>();
            var methodCreateParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String), typeof(int) };
            object[] parametersOfCreate = { dataType, text, objectId, oepLauncherType, level };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreate, methodCreateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<LinkLabel>(_customLinkLabelInstanceFixture, parametersOfCreate);
            var result2 = this.GetResultOfMethod<LinkLabel>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(5);
            methodCreateParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var dataType = this.CreateType<string>();
            var text = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var oepLauncherType = this.CreateType<string>();
            var level = this.CreateType<int>();
            var methodCreateParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String), typeof(int) };
            object[] parametersOfCreate = { dataType, text, objectId, oepLauncherType, level };

            // Act
            Action currentAction = () => this.GetResultOfMethod<LinkLabel>(MethodCreate, parametersOfCreate, methodCreateParametersTypes);

            // Assert
            parametersOfCreate.ShouldNotBeNull();
            parametersOfCreate.Length.ShouldBe(5);
            methodCreateParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var methodCreateParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String), typeof(int) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreate, methodCreateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var currentMethodInfo = this.GetMethodInfo(MethodCreate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Create) (Return Type : LinkLabel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomLinkLabel_Create_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreate);
            var currentMethodInfo = this.GetMethodInfo(MethodCreate, 0);
            const int parametersCount = 5;

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