/* This code is also available with a commercial license.  Please refer to Snasci.com for further information. */

/*
 * Snasci Voice - 3D acoustically modelled voicebox for voice synthesis
 * Copyright (C) 2016 Snasci
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnasciVoiceBox.Respiratory
{
    //Note: Perhaps run on a separate thread.  Ultimately used to control the availability and volume of spectrally biased white noise delivered to the larynx.
    //Support inwards singing???
    //May require modelling the lung cavity - overkill???
    public class Lungs
    {
        public decimal CurrentBreathingRate { get; set; }  //Breaths per second
        public decimal MaxBreathingRate { get; set; }  
        public decimal MinBreathingRate { get; set; }
        public decimal TargetBreathingRate { get; set; }  //Move to this rate
        public decimal AirOutputFlowVolume { get; set; }  //How much air is entering the Larynx (cc per second). Flow of working.
        public decimal CurrentLungCapcity { get; set; } //cc
        public decimal MaxLungCapcity { get; set; } //cc
        public decimal MinLungCapacity { get; set; } //cc
        public decimal WorkingLungCapacity { get; set; } //cc:  (max - min) = working
        public decimal CurrentChangeRate { get; set; }  //how fast we can move from one breathing rate to another
        public decimal MaxChangeRate { get; set; }  //upper limit of how fast we can move from one breathing rate to another
        public decimal MinChangeRate { get; set; }  //lower limit of how fast we can move from one breathing rate to another
        public decimal stepFactor { get; set; } //a multiplier that allows some decoupling from the animation rate. ???  Separate thread
        public byte[] LungWaveOutput { get; set; }  //pcm representing the output of the lungs - spectral content reflective of the above parameters.
    }
}
