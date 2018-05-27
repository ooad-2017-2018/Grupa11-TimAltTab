﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace BeFitAPI.Models
{
    public class ProgramsController : ApiController
    {
        private AspModel db = new AspModel();

        // GET: api/Programs
        public IQueryable<Program> GetProgram()
        {
            return db.Program;
        }

        // GET: api/Programs/5
        [ResponseType(typeof(Program))]
        public IHttpActionResult GetProgram(int id)
        {
            Program program = db.Program.Find(id);
            if (program == null)
            {
                return NotFound();
            }

            return Ok(program);
        }

        // PUT: api/Programs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProgram(int id, Program program)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != program.Id)
            {
                return BadRequest();
            }

            db.Entry(program).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Programs
        [ResponseType(typeof(Program))]
        public IHttpActionResult PostProgram(Program program)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Program.Add(program);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = program.Id }, program);
        }

        // DELETE: api/Programs/5
        [ResponseType(typeof(Program))]
        public IHttpActionResult DeleteProgram(int id)
        {
            Program program = db.Program.Find(id);
            if (program == null)
            {
                return NotFound();
            }

            db.Program.Remove(program);
            db.SaveChanges();

            return Ok(program);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProgramExists(int id)
        {
            return db.Program.Count(e => e.Id == id) > 0;
        }
    }
}