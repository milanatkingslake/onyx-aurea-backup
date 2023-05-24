using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.DataSourceDefinitionOrReference" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DataSourceDefinitionOrReferenceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DataSourceDefinitionOrReference" />)
        /// </summary>
        public DataSourceDefinitionOrReferenceTest() : base(typeof(DataSourceDefinitionOrReference))
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

        #region General Initializer : Class (DataSourceDefinitionOrReference) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dataSourceDefinitionOrReferenceInstanceType;
        private DataSourceDefinitionOrReference _dataSourceDefinitionOrReferenceInstance;
        private DataSourceDefinitionOrReference _dataSourceDefinitionOrReferenceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DataSourceDefinitionOrReference" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dataSourceDefinitionOrReferenceInstanceType = typeof(DataSourceDefinitionOrReference);
            _dataSourceDefinitionOrReferenceInstanceFixture = this.Create<DataSourceDefinitionOrReference>(false);
            _dataSourceDefinitionOrReferenceInstance = _dataSourceDefinitionOrReferenceInstanceFixture ?? this.Create<DataSourceDefinitionOrReference>(true);
            CurrentInstance = _dataSourceDefinitionOrReferenceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (DataSourceDefinitionOrReference) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DataSourceDefinitionOrReference" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DataSourceDefinitionOrReference_Is_Instance_Present_Test()
        {
            // Assert
            _dataSourceDefinitionOrReferenceInstanceType.ShouldNotBeNull();
            _dataSourceDefinitionOrReferenceInstance.ShouldNotBeNull();
            _dataSourceDefinitionOrReferenceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DataSourceDefinitionOrReference) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DataSourceDefinitionOrReference" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DataSourceDefinitionOrReference_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dataSourceDefinitionOrReferenceInstance.ShouldBeAssignableTo<DataSourceDefinitionOrReference>();
            _dataSourceDefinitionOrReferenceInstanceFixture.ShouldBeAssignableTo<DataSourceDefinitionOrReference>();
            CurrentInstance.ShouldBeAssignableTo<DataSourceDefinitionOrReference>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DataSourceDefinitionOrReference) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_DataSourceDefinitionOrReference_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DataSourceDefinitionOrReference instance = null;

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