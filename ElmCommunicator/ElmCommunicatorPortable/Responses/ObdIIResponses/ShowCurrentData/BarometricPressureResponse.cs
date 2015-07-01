﻿// Copyright 2015 Tosho Toshev
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using ElmCommunicatorPortable.Commands;
using UnitsNet;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class BarometricPressureResponse : ResponseMessage
    {
        public override string ExpectedCommand
        {
            get
            {
                return "33";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);

            if (!this.IsValid())
            {
                return null;
            }

            this.Data = message.Substring(4);
            this.Pressure = Pressure.FromKilopascals(this.HexToDec(this.Data));

            return this;
        }

        public Pressure Pressure { get; private set; }
    }
}
