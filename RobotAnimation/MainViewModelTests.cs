using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace RobotAnimation
{
    public class MainWindowViewModelTests
    {
        /// <summary>
        /// Arm1Rotation Tests
        /// </summary>
        [Fact]
        public void Arm1Rotation_RetractAngle_HasAngleEqualTo()
        {
           //Arrange
           MainWindowViewModel viewModel = new MainWindowViewModel();
           //Act
           viewModel.TeachPoint = "5";
           //Assert
           viewModel.Arm1Rotation.RetractAngleStart.Should().Be(0);
           viewModel.Arm1Rotation.RetractAngleEnd.Should().Be(96.219248442880868);
        }

        [Fact]
        public void Arm1Rotation_RotationAngle_HasAngleEqualTo()
        {
            //Arrange
            MainWindowViewModel viewModel = new MainWindowViewModel();
            //Act
            viewModel.TeachPoint = "5";
            //Assert
            viewModel.Arm1Rotation.RotationAngleStart.Should().Be(96.219248442880868);
            viewModel.Arm1Rotation.RotationAngleEnd.Should().Be(186.21924844288088);
        }

        [Fact]
        public void Arm1Rotation_ExpandAngle_HasAngleEqualTo()
        {
            //Arrange
            MainWindowViewModel viewModel = new MainWindowViewModel();
            //Act
            viewModel.TeachPoint = "5";
            //Assert
            viewModel.Arm1Rotation.ExpandAngleStart.Should().Be(186.21924844288088);
            viewModel.Arm1Rotation.ExpandAngleEnd.Should().Be(155.3756816478359);
        }

        /// <summary>
        /// Arm2Rotation Tests
        /// </summary>
        [Fact]
        public void Arm2Rotation_RetractAngle_HasAngleEqualTo()
        {
            //Arrange
            MainWindowViewModel viewModel = new MainWindowViewModel();
            //Act
            viewModel.TeachPoint = "5";
            //Assert
            viewModel.Arm2Rotation.RetractAngleStart.Should().Be(0);
            viewModel.Arm2Rotation.RetractAngleEnd.Should().Be(-192.43849688576174);
        }

        [Fact]
        public void Arm2Rotation_ExpandAngle_HasAngleEqualTo()
        {
            //Arrange
            MainWindowViewModel viewModel = new MainWindowViewModel();
            //Act
            viewModel.TeachPoint = "5";
            //Assert
            viewModel.Arm2Rotation.ExpandAngleStart.Should().Be(-192.43849688576174);
            viewModel.Arm2Rotation.ExpandAngleEnd.Should().Be(-130.75136329567184);
        }

        /// <summary>
        /// Arm3Rotation Tests
        /// </summary>
        [Fact]
        public void Arm3Rotation_RetractAngle_HasAngleEqualTo()
        {
            //Arrange
            MainWindowViewModel viewModel = new MainWindowViewModel();
            //Act
            viewModel.TeachPoint = "5";
            //Assert
            viewModel.Arm3Rotation.RetractAngleStart.Should().Be(0);
            viewModel.Arm3Rotation.RetractAngleEnd.Should().Be(96.219248442880868);
        }

        [Fact]
        public void Arm3Rotation_ExpandAngle_HasAngleEqualTo()
        {
            //Arrange
            MainWindowViewModel viewModel = new MainWindowViewModel();
            //Act
            viewModel.TeachPoint = "5";
            //Assert
            viewModel.Arm3Rotation.ExpandAngleStart.Should().Be(96.219248442880868);
            viewModel.Arm3Rotation.ExpandAngleEnd.Should().Be(65.375681647835918);
        }

        /// <summary>
        /// Method Tests
        /// </summary>

        [Fact]
        public void CalculateAngle_Angle_HasAngleOf65()
        {
            //Arrange
            MainWindowViewModel viewModel = new MainWindowViewModel();
            TeachPoint target = new TeachPoint(90, 50);
            //Act
            var alpha = viewModel.CalculateAngle(target);
            //Assert
            alpha.Should().Be(65.375681647835918);
            //Assert.Equal(65.3756816478359, alpha);
        }
    }
}
