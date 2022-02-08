package com.example.DamRoom.repository;

import com.example.DamRoom.domain.Reservas;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.Date;
import java.util.Optional;
import java.util.Set;

@Repository
public interface ReservaRepository extends CrudRepository<Reservas, Long> {

    Set<Reservas> findAll();
    Optional<Reservas> findReservaByidReserva(long idReserva);
    Set<Reservas> findReservaByfechaIni(Date fechaIni);
    Set<Reservas> findReservaByfechaFin(Date fechaFin);
    Set<Reservas> findReservaByimporte(float importe);
    Set<Reservas> findReservaByestado(String estado);

}
