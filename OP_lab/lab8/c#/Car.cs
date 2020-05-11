using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Car
{
    public class SimpleCar
    {
        public event EventHandler OverSpeed;
        public event Action OutOfFuel;
        public SimpleCar(string name, uint maximumSpeed, uint consumption, uint gasTankVolume)
        {
            _maximumSpeed = maximumSpeed;
            GetConsumption = consumption;
            GasTankVolume = gasTankVolume;
            FuelLevel = 100;
            Name = name;
            OutOfFuel += Stop;
            OutOfFuel += Warning;
        }

        
        public void StartOfMovement()
        {
            if (this._isMove)
            {
                throw new InvalidOperationException("This car was started\n");
            }
            else
            {
                this.Speed = 1;
                this._isMove = true;
                this.FuelConsumption();
            }
        }

        
        public void Movement(uint speed)
        {
            if (speed > _maximumSpeed)
            {
                throw new ArgumentException($"Maximum speed : {_maximumSpeed} km/h");
            }

            if (speed > PermissibleSpeed)
            {
                OverSpeed?.Invoke(this, null!);
            }

            this.Speed = speed;
        }

        
        public void Stop()
        {
            if (!this._isMove)
            {
                throw new InvalidOperationException("This car was not started\n");
            }
            else
            {
                this._isMove = false;
                this.Speed = 0;
            }
        }

        
        public void Refueling()
        {
            if (this._isMove)
            {
                throw new InvalidOperationException("This car is move");
            }
            else
            {
                FuelLevel = 100;
            }
        }

        
        private async void FuelConsumption()
        {
            await Task.Run(() =>
            {
                while (this.FuelLevel > 0 &&this._isMove)
                {
                    System.Threading.Thread.Sleep((int) (GasTankVolume / (Speed * GetConsumption) * 36000000));
                    FuelLevel--;
                    if (FuelLevel == 0)
                    {
                        OutOfFuel?.Invoke();
                    }
                }
            });
        }

        
        public uint Speed { get; private set; } = 0;
        public string Name { get; }
        public uint FuelLevel { get; private set; }
        public uint GetConsumption { get; }
        public uint GasTankVolume { get; }
        
        private bool _isMove = false;
        private readonly uint _maximumSpeed;
        private const uint PermissibleSpeed = 90;

        private void Warning()
        {
            Console.WriteLine("WARNING: Out of fuel");
        }
    }
}