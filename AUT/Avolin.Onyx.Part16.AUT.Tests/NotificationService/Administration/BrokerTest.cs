using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.Broker" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BrokerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="BrokerNonPublicTypeName" />) using
        ///     Using a public type <see cref="DispatchAgentManager" /> to
        ///     create a non-public type.
        /// </summary>
        public BrokerTest() : base(publicType: typeof(DispatchAgentManager), classNameWithNamespace: BrokerNonPublicTypeName)
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

        private Type _brokerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string BrokerNonPublicTypeName = "NotificationService.Administration.Broker";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _brokerInstance;
        private object _brokerInstanceFixture;

        #region General Initializer : Class (Broker) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Broker" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _brokerInstanceFixture = this.CreateNonPublicType(BrokerNonPublicTypeName);
            _brokerInstance = _brokerInstanceFixture;
            CurrentInstance = _brokerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Broker) Initializer

        #region Methods

        private const string MethodDispatch = "Dispatch";
        private const string MethodApplyTemplate = "ApplyTemplate";
        private const string MethodApplyCalendarTemplate = "ApplyCalendarTemplate";
        private const string MethodApplyTemplateInternal = "ApplyTemplateInternal";
        private const string MethodLoadTemplate = "LoadTemplate";

        #endregion

        #region Fields

        private const string FieldSubject = "Subject";
        private const string FieldBody = "Body";
        private const string FieldsubjectFormat = "subjectFormat";
        private const string FieldIsHtmlBody = "IsHtmlBody";
        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Broker)

        #region General Initializer : Class (Broker) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Broker" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodDispatch, 0)]
        [TestCase(MethodDispatch, 1)]
        [TestCase(MethodApplyTemplate, 0)]
        [TestCase(MethodApplyCalendarTemplate, 0)]
        [TestCase(MethodApplyTemplateInternal, 0)]
        [TestCase(MethodLoadTemplate, 0)]
        [Category("AUT Explore")]
        public void AUT_Broker_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Broker) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Broker" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Broker_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Broker) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Broker" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldSubject)]
        [TestCase(FieldBody)]
        [TestCase(FieldsubjectFormat)]
        [TestCase(FieldIsHtmlBody)]
        [Category("AUT Fields")]
        public void AUT_Broker_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Broker) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Broker" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Broker_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}