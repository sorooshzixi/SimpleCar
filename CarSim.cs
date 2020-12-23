using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCar
{
    class CarSim : Car
    {
        public CarSim(string make,string model,int age,bool engine_status, bool gas_pedal_status, bool break_pedal_status,int current_speed) : base(make,model,age)
        {
            this.Speed = current_speed;
            this.Gas_Pedal_Status = gas_pedal_status;
            this.Break_Pedal_Status = break_pedal_status;
            this.Engine_Status = engine_status;
        }
        public int Speed
        { get; set; }
        public bool Gas_Pedal_Status
        { get; set; }
        public bool Break_Pedal_Status
        { get; set; }
        public bool Engine_Status
        { get; set; }

        public int ChangeSpeed() 
        {
            if (Gas_Pedal_Status)
            { Speed += 1; }
            return (Speed);
            
        }
    }
}
