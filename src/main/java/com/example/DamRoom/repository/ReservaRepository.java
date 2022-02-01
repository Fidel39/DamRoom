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
    Optional<Reservas> findAllReservas(int id);
    Set<Reservas> findById(int id);
    Set<Reservas> findByFechaIn(Date fechaIn);
    Set<Reservas> findByFechaFin(Date fechaFin);
    Set<Reservas> findByImporte(float importe);
    Set<Reservas> findByChekin (boolean chekin);
    Set<Reservas> findByChekout (boolean chekout);
    void deleteById(int id);

}
