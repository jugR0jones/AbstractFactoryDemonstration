namespace AbstractFactoryDemonstration
{
    /// <summary>
    /// Concrete implementation of a factory that produces different printer objects.
    /// Two different methods of object creation are demonstrated.
    /// </summary>
    class PrinterFactory
    {

        #region Specific Methods

        public static CanonPrinter MakeCanon()
        {
            return new CanonPrinter();
        }

        public static EpsonPrinter MakeEpson()
        {
            return new EpsonPrinter();
        }

        public static BrotherPrinter MakeBrother()
        {
            return new BrotherPrinter();
        }

        #endregion

        #region Single Method

        public static IPrinter Make(string printer)
        {
            switch(printer.ToLower())
            {
                case "canon":
                    {
                        return new CanonPrinter();
                    }
                case "epson":
                    {
                        return new EpsonPrinter();
                    }
                case "brother":
                    {
                        return new BrotherPrinter();
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        #endregion
    }
}
