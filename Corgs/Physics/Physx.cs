using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Corgs.Physics
{
    class Physx
    {
        public Physx()
        {
            velocity = 1;
            displacement = 1;
            time = 1;
            acceleration = 1;
            deltaVelocity = 1;
            force = 1;
            mass = 1;
        }

        public Physx(double v, double d, double t, double a, double deltaV, double f, double m)
        {
            velocity = v;
            displacement = d;
            time = t;
            acceleration = a;
            deltaVelocity = deltaV;
            force = f;
            mass = m;
        }

        private double calcVelocity(double d, double t)
        {
            try
            {
                velocity = d / t;
                return velocity;
            }
            catch (Exception eV)
            {
                Console.WriteLine(eV);
                throw;
            }
        }

        private double calcAcceleration(double deltaV, double t)
        {
            try
            {
                acceleration = deltaV / t;
                return acceleration;
            }
            catch (Exception eAcc)
            {
                Console.WriteLine(eAcc);
                throw;
            }
        }

        private double calcForce(double m, double a)
        {
            try
            { 
                force = m * a;
                return force;
            }
            catch (Exception eF)
            {
                Console.WriteLine(eF);
                throw;
            }
        }

        public double getVelocity(double d, double t)
        {
            return calcVelocity(d, t);
        }

        public double getAcceleration(double deltaV, double t)
        {
            return calcAcceleration(deltaV,t);
        }

        public double getForce(double m, double a)
        {
            return calcForce(m, a);
        }

        #region MyPolynomial

        public float getPolynomial(string str)
        {
            return calcPolynomial(str);   
        }

        private float calcPolynomial(string strCalc)
        {
            try
            {
                var loDataTable = new DataTable();
                var loDataColumn = new DataColumn("Eval", typeof(float), strCalc);
                loDataTable.Columns.Add(loDataColumn);
                loDataTable.Rows.Add(0);
                return (float)(loDataTable.Rows[0]["Eval"]);
            }
            catch (Exception eCalcPoly)
            {
                Console.WriteLine(eCalcPoly);
                throw;
            }
            
        }

        #endregion

        private double velocity;
        private double displacement;
        private double time;
        private double acceleration;
        private double deltaVelocity;
        private double force;
        private double mass;

    }
}
