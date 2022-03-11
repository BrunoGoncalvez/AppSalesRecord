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

            Seller s1 = new Seller("Will Smith", "will@gmail.com", new DateTime(12/02/1990), 2100.00, d1);
            Seller s2 = new Seller("Dwayne Johnson", "dwayne@gmail.com", new DateTime(02/12/1980), 4580.00, d2);
            Seller s3 = new Seller("Brad Pitt", "brad@gmail.com", new DateTime(10/06/1992), 2550.00, d3);
            Seller s4 = new Seller("Sandra Bullock", "sandra@gmail.com", new DateTime(25/10/1994), 3200.00, d4);
            Seller s5 = new Seller("Julia Roberts", "julia@gmail.com", new DateTime(01/11/1989), 2200.00, d1);
            Seller s6 = new Seller("Leonardo DiCaprio", "dicaprio@gmail.com", new DateTime(07/07/1987), 3800.00, d1);

            SalesRecord r1 = new SalesRecord(new DateTime(03 / 09 / 2022), 1200.00, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(new DateTime(12 / 12 / 2022), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(new DateTime(11 / 02 / 2022), 2500.00, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(new DateTime(24 / 04 / 2022), 4400.00, SaleStatus.Pending, s4);
            SalesRecord r5 = new SalesRecord(new DateTime(17 / 07 / 2022), 3300.00, SaleStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(new DateTime(20 / 12 / 2022), 6300.00, SaleStatus.Pending, s6);
            SalesRecord r7 = new SalesRecord(new DateTime(08 / 10 / 2022), 500.00, SaleStatus.Pending, s1);
            SalesRecord r8 = new SalesRecord(new DateTime(26 / 06 / 2022), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(new DateTime(12 / 12 / 2022), 2300.00, SaleStatus.Pending, s3);
            SalesRecord r10 = new SalesRecord(new DateTime(12 / 12 / 2022), 2300.00, SaleStatus.Pending, s4);
            SalesRecord r11 = new SalesRecord(new DateTime(12 / 12 / 2022), 2300.00, SaleStatus.Pending, s5);
            SalesRecord r12 = new SalesRecord(new DateTime(12 / 02 / 2022), 2300.00, SaleStatus.Pending, s6);
            SalesRecord r13 = new SalesRecord(new DateTime(14 / 09 / 2022), 2300.00, SaleStatus.Pending, s1);
            SalesRecord r14 = new SalesRecord(new DateTime(16 / 09 / 2022), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r15 = new SalesRecord(new DateTime(19 / 08 / 2022), 2300.00, SaleStatus.Pending, s3);
            SalesRecord r16 = new SalesRecord(new DateTime(09 / 05 / 2022), 2300.00, SaleStatus.Pending, s4);
            SalesRecord r17 = new SalesRecord(new DateTime(10 / 06 / 2022), 2300.00, SaleStatus.Pending, s5);
            SalesRecord r18 = new SalesRecord(new DateTime(12 / 10 / 2022), 2300.00, SaleStatus.Pending, s6);
            SalesRecord r19 = new SalesRecord(new DateTime(14 / 03 / 2022), 2300.00, SaleStatus.Pending, s1);
            SalesRecord r20 = new SalesRecord(new DateTime(15 / 12 / 2022), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r21 = new SalesRecord(new DateTime(30 / 11 / 2022), 2300.00, SaleStatus.Pending, s3);
            SalesRecord r22 = new SalesRecord(new DateTime(31 / 10 / 2022), 2300.00, SaleStatus.Pending, s4);
            SalesRecord r23 = new SalesRecord(new DateTime(28 / 05 / 2022), 2300.00, SaleStatus.Pending, s5);
            SalesRecord r24 = new SalesRecord(new DateTime(08 / 12 / 2022), 2300.00, SaleStatus.Pending, s6);
            SalesRecord r25 = new SalesRecord(new DateTime(08 / 02 / 2022), 2300.00, SaleStatus.Pending, s1);
            SalesRecord r26 = new SalesRecord(new DateTime(22 / 07 / 2022), 2300.00, SaleStatus.Pending, s2);
            SalesRecord r27 = new SalesRecord(new DateTime(30 / 07 / 2022), 2300.00, SaleStatus.Pending, s3);
            SalesRecord r28 = new SalesRecord(new DateTime(31 / 09 / 2022), 2300.00, SaleStatus.Pending, s4);
            SalesRecord r29 = new SalesRecord(new DateTime(05 / 10 / 2022), 2300.00, SaleStatus.Pending, s5);
            SalesRecord r30 = new SalesRecord(new DateTime(11 / 08 / 2022), 2300.00, SaleStatus.Pending, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30);

            _context.SaveChanges();


        }


    }
}
