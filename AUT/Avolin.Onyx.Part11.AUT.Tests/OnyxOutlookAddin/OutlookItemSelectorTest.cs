using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OutlookItemSelector" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OutlookItemSelectorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OutlookItemSelector" />)
        /// </summary>
        public OutlookItemSelectorTest() : base(typeof(OutlookItemSelector))
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

        #region General Initializer : Class (OutlookItemSelector) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _outlookItemSelectorInstanceType;
        private OutlookItemSelector _outlookItemSelectorInstance;
        private OutlookItemSelector _outlookItemSelectorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OutlookItemSelector" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookItemSelectorInstanceType = typeof(OutlookItemSelector);
            _outlookItemSelectorInstanceFixture = this.Create<OutlookItemSelector>(false);
            _outlookItemSelectorInstance = _outlookItemSelectorInstanceFixture ?? this.Create<OutlookItemSelector>(true);
            CurrentInstance = _outlookItemSelectorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookItemSelector) Initializer

        #region Methods

        private const string MethodbulkInsertIntoOnyx = "bulkInsertIntoOnyx";

        #endregion

        #endregion

        #region General Initializer : Class (OutlookItemSelector) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookItemSelector" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OutlookItemSelector_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookItemSelector)

        #region General Initializer : Class (OutlookItemSelector) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OutlookItemSelector" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodbulkInsertIntoOnyx, 0)]
        public void AUT_OutlookItemSelector_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OutlookItemSelector) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OutlookItemSelector" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OutlookItemSelector_Is_Instance_Present_Test()
        {
            // Assert
            _outlookItemSelectorInstanceType.ShouldNotBeNull();
            _outlookItemSelectorInstance.ShouldNotBeNull();
            _outlookItemSelectorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OutlookItemSelector) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OutlookItemSelector" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OutlookItemSelector_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _outlookItemSelectorInstance.ShouldBeAssignableTo<OutlookItemSelector>();
            _outlookItemSelectorInstanceFixture.ShouldBeAssignableTo<OutlookItemSelector>();
            CurrentInstance.ShouldBeAssignableTo<OutlookItemSelector>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OutlookItemSelector) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_OutlookItemSelector_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var paramObjs = this.CreateType<List<Object>>();
            var paramHeader = this.CreateType<string>();
            OutlookItemSelector instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OutlookItemSelector(paramObjs, paramHeader);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _outlookItemSelectorInstance.ShouldNotBeNull();
            _outlookItemSelectorInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OutlookItemSelector>();
        }

        #endregion

        #region General Constructor : Class (OutlookItemSelector) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_OutlookItemSelector_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var paramObjs = this.CreateType<List<Object>>();
            var paramHeader = this.CreateType<string>();
            OutlookItemSelector instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OutlookItemSelector(paramObjs, paramHeader);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _outlookItemSelectorInstance.ShouldNotBeNull();
            _outlookItemSelectorInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookItemSelector_bulkInsertIntoOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);

            // Act
            Action executeAction = () => _outlookItemSelectorInstance.bulkInsertIntoOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookItemSelector_bulkInsertIntoOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            Type [] methodbulkInsertIntoOnyxParametersTypes = null;
            object[] parametersOfbulkInsertIntoOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbulkInsertIntoOnyx, methodbulkInsertIntoOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookItemSelectorInstanceFixture, parametersOfbulkInsertIntoOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbulkInsertIntoOnyx.ShouldBeNull();
            methodbulkInsertIntoOnyxParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookItemSelector_bulkInsertIntoOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            Type [] methodbulkInsertIntoOnyxParametersTypes = null;
            object[] parametersOfbulkInsertIntoOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbulkInsertIntoOnyx, parametersOfbulkInsertIntoOnyx, methodbulkInsertIntoOnyxParametersTypes);

            // Assert
            parametersOfbulkInsertIntoOnyx.ShouldBeNull();
            methodbulkInsertIntoOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookItemSelector_bulkInsertIntoOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            Type [] methodbulkInsertIntoOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbulkInsertIntoOnyx, methodbulkInsertIntoOnyxParametersTypes);

            // Assert
            methodbulkInsertIntoOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookItemSelector_bulkInsertIntoOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodbulkInsertIntoOnyx, 0);

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