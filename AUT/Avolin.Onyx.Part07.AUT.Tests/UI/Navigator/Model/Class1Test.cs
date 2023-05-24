using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.Class1" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class Class1Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Class1" />)
        /// </summary>
        public Class1Test() : base(typeof(Class1))
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

        #region General Initializer : Class (Class1) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _class1InstanceType;
        private Class1 _class1Instance;
        private Class1 _class1InstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Class1" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _class1InstanceType = typeof(Class1);
            _class1InstanceFixture = this.Create<Class1>(false);
            _class1Instance = _class1InstanceFixture ?? this.Create<Class1>(true);
            CurrentInstance = _class1Instance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Class1) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Class1" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Class1_Is_Instance_Present_Test()
        {
            // Assert
            _class1InstanceType.ShouldNotBeNull();
            _class1Instance.ShouldNotBeNull();
            _class1InstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Class1) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Class1" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Class1_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _class1Instance.ShouldBeAssignableTo<Class1>();
            _class1InstanceFixture.ShouldBeAssignableTo<Class1>();
            CurrentInstance.ShouldBeAssignableTo<Class1>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Class1) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Class1_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Class1 instance = null;

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