using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.StrDomainData" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StrDomainDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StrDomainData" />)
        /// </summary>
        public StrDomainDataTest() : base(typeof(StrDomainData))
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

        #region General Initializer : Class (StrDomainData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _strDomainDataInstanceType;
        private StrDomainData _strDomainDataInstance;
        private StrDomainData _strDomainDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StrDomainData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _strDomainDataInstanceType = typeof(StrDomainData);
            _strDomainDataInstanceFixture = this.Create<StrDomainData>(false);
            _strDomainDataInstance = _strDomainDataInstanceFixture ?? this.Create<StrDomainData>(true);
            CurrentInstance = _strDomainDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StrDomainData) Initializer

        #region Fields

        private const string FieldCode = "Code";
        private const string FieldDescription = "Description";
        private const string FieldPhoneMask = "PhoneMask";
        private const string FieldPostalcodeMask = "PostalcodeMask";

        #endregion

        #endregion

        #region General Initializer : Class (StrDomainData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StrDomainData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StrDomainData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StrDomainData)

        #region General Initializer : Class (StrDomainData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StrDomainData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldCode)]
        [TestCase(FieldDescription)]
        [TestCase(FieldPhoneMask)]
        [TestCase(FieldPostalcodeMask)]
        [Category("AUT Fields")]
        public void AUT_StrDomainData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StrDomainData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StrDomainData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StrDomainData_Is_Instance_Present_Test()
        {
            // Assert
            _strDomainDataInstanceType.ShouldNotBeNull();
            _strDomainDataInstance.ShouldNotBeNull();
            _strDomainDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StrDomainData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StrDomainData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StrDomainData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _strDomainDataInstance.ShouldBeAssignableTo<StrDomainData>();
            _strDomainDataInstanceFixture.ShouldBeAssignableTo<StrDomainData>();
            CurrentInstance.ShouldBeAssignableTo<StrDomainData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StrDomainData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StrDomainData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            StrDomainData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}