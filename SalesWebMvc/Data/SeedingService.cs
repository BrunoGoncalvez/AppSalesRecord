using System;
using System.Linq;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {

        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) 
            {
                return;
            }

            Department d1 = new Department("Computers");
            Department d2 = new Department("Electronics");
            Department d3 = new Department("Fashion");
            Department d4 = new Department("Books");

            Seller s1 = new Seller("Will Smith", "will@gmail.com", new DateTime(1990, 10, 07), 2100.00, d1);
            Seller s2 = new Seller("Dwayne Johnson", "dwayne@gmail.com", new DateTime(1980, 02, 19), 4580.00, d2);
            Seller s3 = new Seller("Brad Pitt", "brad@gmail.com", new DateTime(1992, 10, 30), 2550.00, d3);
            Seller s4 = new Seller("Sandra Bullock", "sandra@gmail.com", new DateTime(1994, 07, 03), 3200.00, d4);
            Seller s5 = new Seller("Julia Roberts", "julia@gmail.com", new DateTime(1989, 08, 13), 2200.00, d1);
            Seller s6 = new Seller("Leonardo DiCaprio", "dicaprio@gmail.com", new DateTime(1990, 12, 20), 3800.00, d1);

            SalesRecord r1 = new SalesRecord(new DateTime(2022, 10, 12), 1200.00, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(new DateTime(2022, 12, 12), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(new DateTime(2022, 04, 24), 2500.00, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(new DateTime(2022, 03, 22), 4400.00, SaleStatus.Pending, s4);
            SalesRecord r5 = new SalesRecord(new DateTime(2022, 03, 24), 3300.00, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(new DateTime(2022, 06, 30), 6300.00, SaleStatus.Pending, s6);
            SalesRecord r7 = new SalesRecord(new DateTime(2022, 06, 28), 500.00, SaleStatus.Pending, s1);
            SalesRecord r8 = new SalesRecord(new DateTime(2022, 05, 24), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(new DateTime(2022, 04, 22), 2300.00, SaleStatus.Canceled, s3);
            SalesRecord r10 = new SalesRecord(new DateTime(2022, 02, 15), 2300.00, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(new DateTime(2022, 10, 13), 2300.00, SaleStatus.Pending, s5);
            SalesRecord r12 = new SalesRecord(new DateTime(2022, 09, 12), 2300.00, SaleStatus.Canceled, s6);
            SalesRecord r13 = new SalesRecord(new DateTime(2022, 10, 20), 2300.00, SaleStatus.Canceled, s1);
            SalesRecord r14 = new SalesRecord(new DateTime(2022, 09, 12), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r15 = new SalesRecord(new DateTime(2022, 12, 01), 2300.00, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(new DateTime(2022, 11, 1), 2300.00, SaleStatus.Pending, s4);
            SalesRecord r17 = new SalesRecord(new DateTime(2022, 11, 04), 2300.00, SaleStatus.Canceled, s5);
            SalesRecord r18 = new SalesRecord(new DateTime(2022, 04, 08), 2300.00, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(new DateTime(2022, 04, 10), 2300.00, SaleStatus.Pending, s1);
            SalesRecord r20 = new SalesRecord(new DateTime(2022, 05, 02), 2300.00, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(new DateTime(2022, 04, 23), 2300.00, SaleStatus.Pending, s3);
            SalesRecord r22 = new SalesRecord(new DateTime(2022, 06, 11), 2300.00, SaleStatus.Pending, s4);
            SalesRecord r23 = new SalesRecord(new DateTime(2022, 05, 31), 2300.00, SaleStatus.Pending, s5);
            SalesRecord r24 = new SalesRecord(new DateTime(2022, 07, 07), 2300.00, SaleStatus.Billed, s6);
            SalesRecord r25 = new SalesRecord(new DateTime(2022, 09, 06), 2300.00, SaleStatus.Pending, s1);
            SalesRecord r26 = new SalesRecord(new DateTime(2022, 07, 26), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r27 = new SalesRecord(new DateTime(2022, 08, 23), 2300.00, SaleStatus.Billed, s3);
            SalesRecord r28 = new SalesRecord(new DateTime(2022, 09, 30), 2300.00, SaleStatus.Pending, s4);
            SalesRecord r29 = new SalesRecord(new DateTime(2022, 06, 22), 2300.00, SaleStatus.Canceled, s5);
            SalesRecord r30 = new SalesRecord(new DateTime(2022, 07, 27), 2300.00, SaleStatus.Canceled, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30);

            _context.SaveChanges();


        }


    }
}
