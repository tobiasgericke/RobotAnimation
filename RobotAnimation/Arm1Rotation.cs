namespace RobotAnimation
{
    internal class Arm1Rotation : NotifyPropertyChangedBase
    {
        private double expandAngleEnd;
        private double expandAngleStart;
        private double retractAngleEnd;
        private double retractAngleStart;
        private double rotationAngleEnd;
        private double rotationAngleStart;

        public double RetractAngleStart
        {
            get => retractAngleStart;
            set
            {
                retractAngleStart = value;
                OnPropertyChanged();
            }
        }

        public double RetractAngleEnd
        {
            get => retractAngleEnd;
            set
            {
                retractAngleEnd = value;
                OnPropertyChanged();
            }
        }

        public double RotationAngleStart
        {
            get => rotationAngleStart;
            set
            {
                rotationAngleStart = value;
                OnPropertyChanged();
            }
        }

        public double RotationAngleEnd
        {
            get => rotationAngleEnd;
            set
            {
                rotationAngleEnd = value;
                OnPropertyChanged();
            }
        }

        public double ExpandAngleStart
        {
            get => expandAngleStart;
            set
            {
                expandAngleStart = value;
                OnPropertyChanged();
            }
        }

        public double ExpandAngleEnd
        {
            get => expandAngleEnd;
            set
            {
                expandAngleEnd = value;
                OnPropertyChanged();
            }
        }
    }

    internal class Arm2Rotation : NotifyPropertyChangedBase
    {
        private double expandAngleEnd;
        private double expandAngleStart;
        private double retractAngleEnd;
        private double retractAngleStart;

        public double RetractAngleStart
        {
            get => retractAngleStart;
            set
            {
                retractAngleStart = value;
                OnPropertyChanged();
            }
        }

        public double RetractAngleEnd
        {
            get => retractAngleEnd;
            set
            {
                retractAngleEnd = value;
                OnPropertyChanged();
            }
        }

        public double ExpandAngleStart
        {
            get => expandAngleStart;
            set
            {
                expandAngleStart = value;
                OnPropertyChanged();
            }
        }

        public double ExpandAngleEnd
        {
            get => expandAngleEnd;
            set
            {
                expandAngleEnd = value;
                OnPropertyChanged();
            }
        }
    }
}