package com.example.DamRoom.repository;

import com.example.DamRoom.domain.Reservas;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.Date;
import java.util.Optional;
import java.util.Set;

@Repository
public interface ReservaRepository extends CrudRepository<Reservas, Integer> {

    Set<Reservas> findAll();
    Optional<Reservas> findBycodReserva(int codReserva);
    Set<Reservas> findByFechaIni(Date fechaIni);
    Set<Reservas> findByFechaFin(Date fechaFin);
    Set<Reservas> findByImporte(float importe);
    Set<Reservas> findByCheckIn (boolean checkIn);
    Set<Reservas> findByCheckOut (boolean checkOut);

}
