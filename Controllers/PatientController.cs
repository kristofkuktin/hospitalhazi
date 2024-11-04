﻿using HospitalPatientAPI.Context;
using HospitalPatientAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalPatientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly HospitalContext _context;

        public PatientController(HospitalContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;

        }

        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPatient), new { id =patient.Id}, patient);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(int id, Patient patient)
        {
            if (id != patient.Id)
            {
                return BadRequest();
            }

            _context.Entry(patient).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete( "{id}")]
        public async Task<IActionResult> DeletePatient(int id) 
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
