using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Notification.BusinessLayer;
using Onyx.UI.Notification.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Notification.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.BusinessLayer.xmlToObject" />)
    ///     and namespace <see cref="Onyx.UI.Notification.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlToObjectTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="xmlToObject" />)
        /// </summary>
        public XmlToObjectTest() : base(typeof(xmlToObject))
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

        #region General Initializer : Class (xmlToObject) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlToObjectInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="xmlToObject" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlToObjectInstanceType = typeof(xmlToObject);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (xmlToObject) Initializer

        #region Methods

        private const string MethodGetNotificationDetails = "GetNotificationDetails";
        private const string MethodGetSubscribedDetails = "GetSubscribedDetails";
        private const string MethodGetForwardedUser = "GetForwardedUser";
        private const string MethodGetSubscribedNotification = "GetSubscribedNotification";
        private const string MethodEditNotificationSubcription = "EditNotificationSubcription";
        private const string MethodGetCheckServiceStatus = "GetCheckServiceStatus";

        #endregion

        #endregion

        #region General Initializer : Class (xmlToObject) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="xmlToObject" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlToObject_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (xmlToObject)

        #region General Initializer : Class (xmlToObject) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="xmlToObject" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetNotificationDetails, 0)]
        [TestCase(MethodGetSubscribedDetails, 0)]
        [TestCase(MethodGetForwardedUser, 0)]
        [TestCase(MethodGetSubscribedNotification, 0)]
        [TestCase(MethodEditNotificationSubcription, 0)]
        [TestCase(MethodGetCheckServiceStatus, 0)]
        public void AUT_XmlToObject_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (xmlToObject) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="xmlToObject" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlToObject_Is_Static_Type_Present_Test()
        {
            // Assert
            _xmlToObjectInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetNotificationDetails(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var strXml = this.CreateType<string>();
            var returnedValue = default(NotificationDetails);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetNotificationDetails(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var strXml = this.CreateType<string>();
            var methodGetNotificationDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNotificationDetails = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotificationDetails, methodGetNotificationDetailsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNotificationDetails);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNotificationDetails.ShouldNotBeNull();
            parametersOfGetNotificationDetails.Length.ShouldBe(1);
            methodGetNotificationDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var strXml = this.CreateType<string>();
            var methodGetNotificationDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNotificationDetails = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<NotificationDetails>(MethodGetNotificationDetails, parametersOfGetNotificationDetails, methodGetNotificationDetailsParametersTypes);

            // Assert
            parametersOfGetNotificationDetails.ShouldNotBeNull();
            parametersOfGetNotificationDetails.Length.ShouldBe(1);
            methodGetNotificationDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var methodGetNotificationDetailsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNotificationDetails, methodGetNotificationDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNotificationDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var methodGetNotificationDetailsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNotificationDetails, methodGetNotificationDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNotificationDetailsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotificationDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationDetails) (Return Type : NotificationDetails) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNotificationDetails_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotificationDetails, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetSubscribedDetails_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSubscribedDetailsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubscribedDetails, methodGetSubscribedDetailsParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetSubscribedDetails(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var strXml = this.CreateType<string>();
            var returnedValue = default(SubscribedDetails);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetSubscribedDetails(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var strXml = this.CreateType<string>();
            var methodGetSubscribedDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSubscribedDetails = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedDetails, methodGetSubscribedDetailsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSubscribedDetails);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSubscribedDetails.ShouldNotBeNull();
            parametersOfGetSubscribedDetails.Length.ShouldBe(1);
            methodGetSubscribedDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var strXml = this.CreateType<string>();
            var methodGetSubscribedDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSubscribedDetails = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SubscribedDetails>(MethodGetSubscribedDetails, parametersOfGetSubscribedDetails, methodGetSubscribedDetailsParametersTypes);

            // Assert
            parametersOfGetSubscribedDetails.ShouldNotBeNull();
            parametersOfGetSubscribedDetails.Length.ShouldBe(1);
            methodGetSubscribedDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var methodGetSubscribedDetailsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedDetails, methodGetSubscribedDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var methodGetSubscribedDetailsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedDetails, methodGetSubscribedDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedDetailsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedDetails) (Return Type : SubscribedDetails) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedDetails_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedDetails, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetForwardedUser_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetForwardedUserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetForwardedUser, methodGetForwardedUserParametersTypes);
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetForwardedUser(strXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<ForwardedUsers>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetForwardedUser(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var strXml = this.CreateType<string>();
            var methodGetForwardedUserParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetForwardedUser = { strXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetForwardedUser, methodGetForwardedUserParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetForwardedUser, methodGetForwardedUserParametersTypes);
            var result2 = this.GetResultOfMethod<List<ForwardedUsers>>(MethodGetForwardedUser, parametersOfGetForwardedUser, methodGetForwardedUserParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetForwardedUser);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetForwardedUser.ShouldNotBeNull();
            parametersOfGetForwardedUser.Length.ShouldBe(1);
            methodGetForwardedUserParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var strXml = this.CreateType<string>();
            var methodGetForwardedUserParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetForwardedUser = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ForwardedUsers>>(MethodGetForwardedUser, parametersOfGetForwardedUser, methodGetForwardedUserParametersTypes);

            // Assert
            parametersOfGetForwardedUser.ShouldNotBeNull();
            parametersOfGetForwardedUser.Length.ShouldBe(1);
            methodGetForwardedUserParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var methodGetForwardedUserParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetForwardedUser, methodGetForwardedUserParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetForwardedUserParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var methodGetForwardedUserParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetForwardedUser, methodGetForwardedUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetForwardedUserParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var currentMethodInfo = this.GetMethodInfo(MethodGetForwardedUser, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUser) (Return Type : List<ForwardedUsers>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetForwardedUser_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUser);
            var currentMethodInfo = this.GetMethodInfo(MethodGetForwardedUser, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetSubscribedNotification_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSubscribedNotificationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetSubscribedNotification(strXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var strXml = this.CreateType<string>();
            var returnedValue = default(SubscribedDetails);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetSubscribedNotification(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var strXml = this.CreateType<string>();
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSubscribedNotification = { strXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);
            var result2 = this.GetResultOfMethod<SubscribedDetails>(MethodGetSubscribedNotification, parametersOfGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSubscribedNotification);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubscribedNotification.ShouldNotBeNull();
            parametersOfGetSubscribedNotification.Length.ShouldBe(1);
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var strXml = this.CreateType<string>();
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSubscribedNotification = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SubscribedDetails>(MethodGetSubscribedNotification, parametersOfGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            parametersOfGetSubscribedNotification.ShouldNotBeNull();
            parametersOfGetSubscribedNotification.Length.ShouldBe(1);
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotification, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : SubscribedDetails) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSubscribedNotification_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotification, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_EditNotificationSubcription_Static_Method_Call_Internally(Type[] types)
        {
            var methodEditNotificationSubcriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEditNotificationSubcription, methodEditNotificationSubcriptionParametersTypes);
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.EditNotificationSubcription(strXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var strXml = this.CreateType<string>();
            var returnedValue = default(NotificationDetails);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.EditNotificationSubcription(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var strXml = this.CreateType<string>();
            var methodEditNotificationSubcriptionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfEditNotificationSubcription = { strXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEditNotificationSubcription, methodEditNotificationSubcriptionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodEditNotificationSubcription, methodEditNotificationSubcriptionParametersTypes);
            var result2 = this.GetResultOfMethod<NotificationDetails>(MethodEditNotificationSubcription, parametersOfEditNotificationSubcription, methodEditNotificationSubcriptionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfEditNotificationSubcription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfEditNotificationSubcription.ShouldNotBeNull();
            parametersOfEditNotificationSubcription.Length.ShouldBe(1);
            methodEditNotificationSubcriptionParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var strXml = this.CreateType<string>();
            var methodEditNotificationSubcriptionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfEditNotificationSubcription = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<NotificationDetails>(MethodEditNotificationSubcription, parametersOfEditNotificationSubcription, methodEditNotificationSubcriptionParametersTypes);

            // Assert
            parametersOfEditNotificationSubcription.ShouldNotBeNull();
            parametersOfEditNotificationSubcription.Length.ShouldBe(1);
            methodEditNotificationSubcriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var methodEditNotificationSubcriptionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEditNotificationSubcription, methodEditNotificationSubcriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodEditNotificationSubcriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var methodEditNotificationSubcriptionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEditNotificationSubcription, methodEditNotificationSubcriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEditNotificationSubcriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var currentMethodInfo = this.GetMethodInfo(MethodEditNotificationSubcription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EditNotificationSubcription) (Return Type : NotificationDetails) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_EditNotificationSubcription_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEditNotificationSubcription);
            var currentMethodInfo = this.GetMethodInfo(MethodEditNotificationSubcription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCheckServiceStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetCheckServiceStatus(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetCheckServiceStatus(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCheckServiceStatus = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCheckServiceStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCheckServiceStatus.ShouldNotBeNull();
            parametersOfGetCheckServiceStatus.Length.ShouldBe(1);
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCheckServiceStatus = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCheckServiceStatus, parametersOfGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);

            // Assert
            parametersOfGetCheckServiceStatus.ShouldNotBeNull();
            parametersOfGetCheckServiceStatus.Length.ShouldBe(1);
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCheckServiceStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCheckServiceStatus, 0);
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