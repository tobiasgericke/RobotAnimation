using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RobotAnimation
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private string teachPointKey = "1";
        private Dictionary<string,TeachPoint> testPoints = new Dictionary<string, TeachPoint>()
        {
            {"1", new TeachPoint(0,100)},
            {"2", new TeachPoint(180,70)},
            {"3", new TeachPoint(270,100)},
            {"4", new TeachPoint(0,10)},
            {"5", new TeachPoint(90,50)}
        };

        private Arm1Rotation arm1ArmRotation = new Arm1Rotation();
        private Arm2Rotation arm2ArmRotation = new Arm2Rotation();
        private Arm2Rotation arm3ArmRotation = new Arm2Rotation();

        private bool startAnimationArm1 = false;
        private bool startAnimationArm2 = false;
        private bool startAnimationArm3 = false;

        public MainWindowViewModel()
        {

        }

        public Arm1Rotation Arm1Rotation { get => arm1ArmRotation; }
        public Arm2Rotation Arm2Rotation { get => arm2ArmRotation; }
        public Arm2Rotation Arm3Rotation { get => arm3ArmRotation; }

        public string TeachPoint
        {
            get => teachPointKey;
            set
            {
                teachPointKey = value;
                if (!testPoints.TryGetValue(value, out var targetTeachPoint))
                {
                    return;
                }

                this.StartAnimationArm1 = false;
                
                var retractAlpha = CalculateAngle(5);
                double alpha = CalculateAngle(targetTeachPoint);

                //Setzen des Startwinkels auf letzten Endwinkel
                this.Arm1Rotation.RetractAngleStart = this.Arm1Rotation.ExpandAngleEnd;
                //Setzen des Einzugswinkels auf Startwinkel + alpha bei Radius von 5
                this.Arm1Rotation.RetractAngleEnd = this.Arm1Rotation.RetractAngleStart - retractAlpha;
                //Von hier aus dann Rotation zum Zielpunkt
                this.Arm1Rotation.RotationAngleStart = this.Arm1Rotation.RetractAngleEnd;

                this.Arm1Rotation.RotationAngleEnd = retractAlpha + targetTeachPoint.Angle;
                
                if (Arm1Rotation.RotationAngleEnd > 180)
                {
                    Arm1Rotation.RotationAngleEnd -= 360;
                }

                //Ausfahren des Arms zum Endpunkt des Teachpoints
                this.Arm1Rotation.ExpandAngleStart = this.Arm1Rotation.RotationAngleEnd;
                this.Arm1Rotation.ExpandAngleEnd = targetTeachPoint.Angle + alpha;

                this.Arm2Rotation.RetractAngleStart = this.Arm2Rotation.ExpandAngleEnd;
                this.Arm2Rotation.RetractAngleEnd = -2 * retractAlpha;
                this.Arm2Rotation.ExpandAngleStart = this.Arm2Rotation.RetractAngleEnd;
                this.Arm2Rotation.ExpandAngleEnd = -2 * alpha;

                this.Arm3Rotation.RetractAngleStart = this.Arm3Rotation.ExpandAngleEnd;
                this.Arm3Rotation.RetractAngleEnd = retractAlpha;
                this.Arm3Rotation.ExpandAngleStart = this.Arm3Rotation.RetractAngleEnd;
                this.Arm3Rotation.ExpandAngleEnd = alpha;

                this.StartAnimationArm1 = true;
            }
        }

        public bool StartAnimationArm1
        {
            get => startAnimationArm1;
            set
            {
                startAnimationArm1 = value;
                NotifyPropertyChanged("StartAnimationArm1");
            }
        }

        public bool StartAnimationArm2
        {
            get => startAnimationArm2;
            set
            {
                startAnimationArm2 = value;
                NotifyPropertyChanged("StartAnimationArm2");
            }
        }

        public bool StartAnimationArm3
        {
            get => startAnimationArm3;
            set
            {
                startAnimationArm3 = value;
                NotifyPropertyChanged("StartAnimationArm3");
            }
        }

        public double CalculateAngle(TeachPoint target)
        {
            double targetRadius = target.Radius;
            var c = (350 * targetRadius / 100) - 50;
            double alpha = Math.Acos((c / 2) / (150)) * 180 / Math.PI;
            return alpha;
        }

        public double CalculateAngle(float radius)
        {
            double targetRadius = radius;
            var c = (350 * targetRadius / 100) - 50;
            double alpha = Math.Acos((c / 2) / (150)) * 180 / Math.PI;
            return alpha;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
