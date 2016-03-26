using System;
using SharpDX;
using SharpDX.Direct3D9;
using Color = System.Drawing.Color;
using EloBuddy;
using InfazLucian;

namespace InfazLucıan
{
    internal class HpBarIndicator
    {
        public static Device dxDevice = Drawing.Direct3DDevice;
        public static Line dxLine;

        public float hight = 9;
        public float width = 104;


        public HpBarIndicator()
        {
            dxLine = new Line(dxDevice) { Width = 9 };

            Drawing.OnPreReset += DrawingOnOnPreReset;
            Drawing.OnPostReset += DrawingOnOnPostReset;
            AppDomain.CurrentDomain.DomainUnload += CurrentDomainOnDomainUnload;
            AppDomain.CurrentDomain.ProcessExit += CurrentDomainOnDomainUnload;
        }

        public Obj_AI_Hero unit { get; set; }

        private Vector2 Offset
        {
            get
            {
                if (unit != null)
                {
                    return unit.IsAlly ? new Vector2(34, 9) : new Vector2(10, 20);
                }

                return new Vector2();
            }
        }

        
        
           
        


        private static void CurrentDomainOnDomainUnload(object sender, EventArgs eventArgs)
        {
            dxLine.Dispose();
        }

        private static void DrawingOnOnPostReset(EventArgs args)
        {
            dxLine.OnResetDevice();
        }

        private static void DrawingOnOnPreReset(EventArgs args)
        {
            dxLine.OnLostDevice();
        }


        private float getHpProc(float dmg = 0)
        {
            float health = ((unit.Health - dmg) > 0) ? (unit.Health - dmg) : 0;
            return (health / unit.MaxHealth);
        }

        internal void drawDmg(float v, ColorBGRA colorBGRA)
        {
            throw new NotImplementedException();
        }
    }

        
      
            //fillHPBar((int)(hpPosNow.X - startPosition.X), (int)(hpPosAfter.X- startPosition.X), color);
        }

        
        
            
            
                
           
        

        
        
           
               

           
        
    
